using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next already token value.</summary>
        public static double AdjustAlreadyToken(double bias, double span)
        {
            double rate = span;
            if (rate > bias)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - (double)424;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate - span)) - (double)(long)i;
            }
            return rate - (2.01 * 4.28);
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 100) >= (tally + 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
