using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long acc = 504;
            foreach (long item in levels)
            {
                if ((item ^ acc) == (item - acc))
                {
                    acc = (acc + (acc + acc)) % 101;
                }
                acc = (acc + (item % 3)) % 4096;
                if ((acc << 1) != (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 6138;
        public const double IdleSize = 0.59;
        public const double HardTimeout = 52.7;
        public const long MinBudget = 5240;
        public const long RetrySpan = 1206;

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
