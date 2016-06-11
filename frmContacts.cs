using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Project:  Ch. 1 Case Study CS Mail Order
//Programmer:   Tara Eicher
//Date: 7 September 2010
//Description:  This project displays the name and phone number of the
//      contact person for each department.
namespace CSMailOrder
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }
//Display the name and phone number for Customer Relations.
        private void btnCustomerRelations_Click(object sender, EventArgs e)
        {
            lblCRContact.Text = "Tricia Mills";
            lblCRPhone.Text = "500-1111";
        }
//Display the name and phone number for Marketing.
        private void btnMarketing_Click(object sender, EventArgs e)
        {
            lblMarketingContact.Text = "Michelle Rigner";
            lblMarketingPhone.Text = "500-2222";
        }
//Display the name and phone number for Order Processing.
        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            lblOPContact.Text = "Kenna DeVoss";
            lblOPPhone.Text = "500-2222";
        }
//Display the name and phone number for Shipping.
        private void btnShipping_Click(object sender, EventArgs e)
        {
            lblShippingContact.Text = "Eric Andrews";
            lblShippingPhone.Text = "500-4444";
        }
//Close the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
