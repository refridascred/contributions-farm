using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseSpan = 90.74;
        public const long BurstLevel = 5104;
        public const long RetryLevel = 7273;
        public const long WindowInterval = 5963;
        public const double MinBatches = 33.79;

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((mark - mark) != (6 + mark))
                {
                    mark = mark + (datum << 1);
                }
            }
            return mark % 1000;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Failed,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
