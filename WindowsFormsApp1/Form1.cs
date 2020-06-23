using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__USERS_PRATIK_DESKTOP_JOBADDA_APP_DATA_JOBPORTALDB_MDFDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this._C__USERS_PRATIK_DESKTOP_JOBADDA_APP_DATA_JOBPORTALDB_MDFDataSet.Area);
            // TODO: This line of code loads data into the 'smitdbDataSet.Tablesmit' table. You can move, or remove it, as needed.
            this.tablesmitTableAdapter.Fill(this.smitdbDataSet.Tablesmit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["smitdbConnectionString"].ToString());
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK3E55E\SMITSQL;Initial Catalog=smitdb;Integrated Security=True");
            SqlDataAdapter da;
            DataTable ds;
            string qry = "select * from Tablesmit";
            da = new SqlDataAdapter(qry, con);
            ds = new DataTable();
            da.Fill(ds);

            dataGridView1.DataSource = ds;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Area Updated";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK3E55E\SMITSQL;Initial Catalog=HRMSdb;Integrated Security=True");
            SqlDataAdapter da;
            DataTable ds;

            DataTable dsnew;


            string qry = "select * from area";
            da = new SqlDataAdapter(qry, con);
            ds = new DataTable();
            da.Fill(ds);

            dsnew = ds;

            dataGridView2.DataSource = ds;
        }
    }
}
