namespace Form_Photoelectricity
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_video = new System.Windows.Forms.GroupBox();
            this.groupBox_CameraSetting = new System.Windows.Forms.GroupBox();
            this.groupBox_WorkPattern = new System.Windows.Forms.GroupBox();
            this.groupBox_TrackStatus = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox_video
            // 
            this.groupBox_video.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_video.Location = new System.Drawing.Point(17, 33);
            this.groupBox_video.Name = "groupBox_video";
            this.groupBox_video.Size = new System.Drawing.Size(539, 574);
            this.groupBox_video.TabIndex = 0;
            this.groupBox_video.TabStop = false;
            this.groupBox_video.Text = "视频显示";
            this.groupBox_video.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_CameraSetting
            // 
            this.groupBox_CameraSetting.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_CameraSetting.Location = new System.Drawing.Point(575, 33);
            this.groupBox_CameraSetting.Name = "groupBox_CameraSetting";
            this.groupBox_CameraSetting.Size = new System.Drawing.Size(280, 180);
            this.groupBox_CameraSetting.TabIndex = 1;
            this.groupBox_CameraSetting.TabStop = false;
            this.groupBox_CameraSetting.Text = "相机设置";
            // 
            // groupBox_WorkPattern
            // 
            this.groupBox_WorkPattern.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_WorkPattern.Location = new System.Drawing.Point(575, 230);
            this.groupBox_WorkPattern.Name = "groupBox_WorkPattern";
            this.groupBox_WorkPattern.Size = new System.Drawing.Size(280, 180);
            this.groupBox_WorkPattern.TabIndex = 2;
            this.groupBox_WorkPattern.TabStop = false;
            this.groupBox_WorkPattern.Text = "工作模式";
            // 
            // groupBox_TrackStatus
            // 
            this.groupBox_TrackStatus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_TrackStatus.Location = new System.Drawing.Point(575, 427);
            this.groupBox_TrackStatus.Name = "groupBox_TrackStatus";
            this.groupBox_TrackStatus.Size = new System.Drawing.Size(280, 180);
            this.groupBox_TrackStatus.TabIndex = 2;
            this.groupBox_TrackStatus.TabStop = false;
            this.groupBox_TrackStatus.Text = "追踪状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(875, 626);
            this.Controls.Add(this.groupBox_TrackStatus);
            this.Controls.Add(this.groupBox_WorkPattern);
            this.Controls.Add(this.groupBox_CameraSetting);
            this.Controls.Add(this.groupBox_video);
            this.Name = "Form1";
            this.Text = "机载光电平台";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_video;
        private System.Windows.Forms.GroupBox groupBox_CameraSetting;
        private System.Windows.Forms.GroupBox groupBox_WorkPattern;
        private System.Windows.Forms.GroupBox groupBox_TrackStatus;
    }
}

