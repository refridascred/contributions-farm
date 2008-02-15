using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long CountChecksStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)datum > (double)hits) && ((7.91 * 17.0) >= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 49.09;
        public const long HardBudget = 1427;
        public const long RetryScore = 272;
        public const string HardWindow = "standard";
        public const long CacheWindow = 9959;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)floor > 16.0)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
