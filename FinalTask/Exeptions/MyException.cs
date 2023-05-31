using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{

    /// <summary>
    /// Класс для создания собственного исключения.
    /// </summary>
    public class MyException : Exception
    {

        public MyException(string message) : base(message) { }
    }
}
