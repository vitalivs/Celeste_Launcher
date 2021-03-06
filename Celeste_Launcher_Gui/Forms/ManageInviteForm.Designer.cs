﻿namespace Celeste_Launcher_Gui.Forms
{
    partial class ManageInviteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInviteForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lv_AvInvite = new System.Windows.Forms.ListView();
            this.ch_InviteNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_UsedInvite = new System.Windows.Forms.ListView();
            this.ch_InviteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_UsedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainContainer1 = new Celeste_Launcher_Gui.Controls.MainContainer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // lv_AvInvite
            // 
            resources.ApplyResources(this.lv_AvInvite, "lv_AvInvite");
            this.lv_AvInvite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_AvInvite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_InviteNum});
            this.lv_AvInvite.FullRowSelect = true;
            this.lv_AvInvite.MultiSelect = false;
            this.lv_AvInvite.Name = "lv_AvInvite";
            this.lv_AvInvite.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_AvInvite.UseCompatibleStateImageBehavior = false;
            this.lv_AvInvite.View = System.Windows.Forms.View.Details;
            this.lv_AvInvite.SelectedIndexChanged += new System.EventHandler(this.lv_AvInvite_SelectedIndexChanged);
            // 
            // ch_InviteNum
            // 
            resources.ApplyResources(this.ch_InviteNum, "ch_InviteNum");
            // 
            // lv_UsedInvite
            // 
            resources.ApplyResources(this.lv_UsedInvite, "lv_UsedInvite");
            this.lv_UsedInvite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_UsedInvite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_InviteId,
            this.ch_UsedBy});
            this.lv_UsedInvite.FullRowSelect = true;
            this.lv_UsedInvite.Name = "lv_UsedInvite";
            this.lv_UsedInvite.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_UsedInvite.UseCompatibleStateImageBehavior = false;
            this.lv_UsedInvite.View = System.Windows.Forms.View.Details;
            // 
            // ch_InviteId
            // 
            resources.ApplyResources(this.ch_InviteId, "ch_InviteId");
            // 
            // ch_UsedBy
            // 
            resources.ApplyResources(this.ch_UsedBy, "ch_UsedBy");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.BackgroundTexture;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lv_AvInvite);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.BarSeparatorVertical;
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lv_UsedInvite);
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // mainContainer1
            // 
            resources.ApplyResources(this.mainContainer1, "mainContainer1");
            this.mainContainer1.BackColor = System.Drawing.Color.Transparent;
            this.mainContainer1.MinimizeBox = false;
            this.mainContainer1.Name = "mainContainer1";
            // 
            // ManageInviteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ManageInviteForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ManageInviteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lv_AvInvite;
        private System.Windows.Forms.ColumnHeader ch_InviteNum;
        private System.Windows.Forms.ListView lv_UsedInvite;
        private System.Windows.Forms.ColumnHeader ch_InviteId;
        private System.Windows.Forms.ColumnHeader ch_UsedBy;
        private System.Windows.Forms.Panel panel1;
        private Controls.MainContainer mainContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}