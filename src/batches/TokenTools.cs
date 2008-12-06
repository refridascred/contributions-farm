using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a graph editor reading.</summary>
        public static double BlendGraphEditor(double bias, double span)
        {
            double load = span * 9.97;
            if (load > (2.16 * 5.7))
            {
                load = load - (span / 5.0);
            }
            else
            {
                load = load - (double)97;
            }
            return load + (bias + 15.0);
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Done,
            Closed,
            Idle,
        }
    }
}
