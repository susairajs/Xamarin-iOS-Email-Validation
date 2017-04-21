using System;
using System.Text.RegularExpressions;
using UIKit;

namespace XamariniOSEmailValidation
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnValidate_TouchUpInside(UIButton sender)
		{
			string email = txtEmail.Text;

			if (Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
			{
				lblMessage.Text = "Your Email (" + email + ") is Correct ";
				lblMessage.TextColor = UIColor.Green;
			}
			else
			{
				lblMessage.Text = "Your Email (" + email + ") is Incorrect ";
				lblMessage.TextColor = UIColor.Red;
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
