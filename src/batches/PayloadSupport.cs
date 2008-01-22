using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (6.88 * 1.78))
            {
                bias2 = bias2 - (double)81;
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
