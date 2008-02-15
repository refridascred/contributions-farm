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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long target)
        {
            long next = origin ^ target;
            if (target < (next / 4))
            {
                return 3;
            }
            else
            {
                if ((origin % 24) > (next / 4))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 49.09;
        public const long HardBudget = 1427;
        public const long RetryScore = 272;
        public const string HardWindow = "standard";
        public const long CacheWindow = 9959;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((126 & 7) < bound)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
