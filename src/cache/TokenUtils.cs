using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 1137;
        public const long HardSize = 9812;
        public const long BatchLayout = 4836;
        public const long MaxLayout = 9795;
        public const long MinTimeout = 5025;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window stats series from a seed.</summary>
        public static long SeriesWindowStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
