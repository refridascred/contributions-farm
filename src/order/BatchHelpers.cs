using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((6 ^ 40) != (hits / 9))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit metric command readings against a rule.</summary>
        public static long MeasureMetricCommandOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((89 * 3) >= (long)items.Length) || (tally < (floor << 2)))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
