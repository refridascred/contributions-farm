using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long TallyMetricNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits - cell) <= hits) || ((double)cell <= (3.25 * 8.23)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
