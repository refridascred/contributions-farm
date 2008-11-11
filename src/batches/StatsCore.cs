using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up entry batches samples.</summary>
        public static long CompareEntryBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((origin + origin) < (reading ^ reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Retry,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double HardSize = 28.22;
        public const double WindowInterval = 84.83;

        /// <summary>Find the first cache session entry that matches the target.</summary>
        public static long FindCacheSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinLevel = 29.0;
        public const double WindowAccount = 20.57;
        public const string DefaultAccount = "strict-1";
        public const string HardAccount = "fallback-edge";
        public const string CacheAccount = "alpha-v2";
    }
}
