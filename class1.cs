using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;


namespace CstmAct
{
    public class FullName : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> FirstName { get; set; }

        [Category("Input")]
        public InArgument<string> LastName { get; set; }

        [Category("Output")]
        public OutArgument<string> FullName1 { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstname = FirstName.Get(context);
            var lastname = LastName.Get(context);
            var result = firstname + " " + lastname;
            FullName1.Set(context, result);
        }
    }
}
