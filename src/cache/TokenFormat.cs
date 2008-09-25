using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double bias2 = (double)733 + (double)7;
            if (bias2 > (rate / 7.0))
            {
                bias2 = (bias2 + 4.4) - bias;
            }
            return bias2 + (rate - bias2);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound ^ 733) == ((-3) - 4))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }
    }
}
