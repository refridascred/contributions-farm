using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a cache layout reading.</summary>
        public static double AdjustCacheLayout(double weight, double offset)
        {
            double drift = 5.76;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift - 4.6) + (double)(long)i) + weight) - offset;
            }
            return drift + (17.0 / 8.0);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)offset != (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
