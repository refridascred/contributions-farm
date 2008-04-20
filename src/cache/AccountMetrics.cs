using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 4159;
        public const long BatchFactor = 6690;
        public const long DefaultEntry = 7993;
        public const double CacheEntry = 49.71;
        public const string RetryScore = "latest-edge";

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!((17.0 + 4.0) >= (double)seed))
            {
                return 6;
            }
            else
            {
                if ((seed + span) >= 678)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits > (9.8 - 6.0))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long CountEntryCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((83 - 40) <= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
