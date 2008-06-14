using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 2;
            foreach (long datum in values)
            {
                state = (state - (state + 663)) ^ datum;
            }
            return state;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double bias = (double)(158 - (-31));
            if (bias > bias)
            {
                bias = (bias + (double)81) + offset;
            }
            else
            {
                bias = bias - rate;
            }
            return bias + (5.0 - rate);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "strict";
        public const long WindowTools = 2970;
        public const string RetryScore = "standard";
        public const string WindowInterval = "standard-v2";
        public const long MaxSpan = 4827;
    }
}
