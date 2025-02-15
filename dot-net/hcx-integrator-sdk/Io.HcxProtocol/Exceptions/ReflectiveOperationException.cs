﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Io.HcxProtocol.Exceptions
{
    public class ReflectiveOperationException : Exception
    {
        //JAVA TO C# CONVERTER TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @java.io.Serial static final long serialVersionUID = 123456789L;
        internal const long serialVersionUID = 123456789L;

        /// <summary>
        /// Constructs a new exception with {@code null} as its detail
        /// message.  The cause is not initialized, and may subsequently be
        /// initialized by a call to <seealso cref="initCause"/>.
        /// </summary>
        public ReflectiveOperationException() : base()
        {
        }

        /// <summary>
        /// Constructs a new exception with the specified detail message.
        /// The cause is not initialized, and may subsequently be
        /// initialized by a call to <seealso cref="initCause"/>.
        /// </summary>
        /// <param name="message">   the detail message. The detail message is saved for
        ///          later retrieval by the <seealso cref="getMessage()"/> method. </param>
        public ReflectiveOperationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructs a new exception with the specified detail message
        /// and cause.
        /// 
        /// <para>Note that the detail message associated with
        /// {@code cause} is <em>not</em> automatically incorporated in
        /// this exception's detail message.
        /// 
        /// </para>
        /// </summary>
        /// <param name="message"> the detail message (which is saved for later retrieval
        ///         by the <seealso cref="getMessage()"/> method). </param>
        /// <param name="cause"> the cause (which is saved for later retrieval by the
        ///         <seealso cref="getCause()"/> method).  (A {@code null} value is
        ///         permitted, and indicates that the cause is nonexistent or
        ///         unknown.) </param>
        public ReflectiveOperationException(string message, Exception cause) : base(message, cause)
        {
        }

        /// <summary>
        /// Constructs a new exception with the specified cause and a detail
        /// message of {@code (cause==null ? null : cause.toString())} (which
        /// typically contains the class and detail message of {@code cause}).
        /// </summary>
        /// <param name="cause"> the cause (which is saved for later retrieval by the
        ///         <seealso cref="getCause()"/> method).  (A {@code null} value is
        ///         permitted, and indicates that the cause is nonexistent or
        ///         unknown.) </param>
        public ReflectiveOperationException(Exception cause) : base(cause.ToString())
        {

        }

        
    }

}
