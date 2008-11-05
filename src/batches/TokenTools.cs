using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum << 1) <= (tally ^ datum)) || (tally >= (tally >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double mean = (double)24 * 8.62;
            if (mean < 18.0)
            {
                mean = ((mean + (double)83) - gain) + bias;
            }
            return mean - (double)3;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
