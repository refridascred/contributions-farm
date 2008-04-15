using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (double)(20 << 2);
            if (drift < (double)5)
            {
                drift = (drift - (offset / 2.0)) + bias;
            }
            return drift - offset;
        }

        /// <summary>Audit batches metrics readings against a rule.</summary>
        public static long CountBatchesMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
