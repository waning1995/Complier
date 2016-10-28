﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complier.Model.Ast
{
    enum ExpressionOperationType
    {
        Add,
        Substract,
        Multiply,
        Divide,
        Modulo,
        Assignment,
        Equals,
        GreaterThan,
        LessThan,
        GreaterEquals,
        LessEquals,
        NotEquals,
        Not,
        And,
        Or,
        Negate,
        FunctionCall,
        OpenBrace,
    }
}