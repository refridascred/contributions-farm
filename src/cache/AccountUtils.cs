using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long target)
        {
            long anchor = 58;
            foreach (long sample in items)
            {
                if (target < (target & 31))
                {
                    anchor = ((anchor ^ (15 * 4)) % 255) - sample;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
