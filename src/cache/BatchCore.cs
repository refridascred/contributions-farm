using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 63;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value << 1);
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxTimeout = 1987;
        public const long SoftWidth = 7618;
        public const long CacheCount = 4491;

        /// <summary>Look up the position of a context batches sample.</summary>
        public static long LocateContextBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
