using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long bound)
        {
            if (((-4) >= (bound + (-296))) && ((2.0 + 8.28) < (double)offset))
            {
                return 4;
            }
            else
            {
                if (((bound / 2) >= offset) && ((3.3 - 5.4) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (!((offset >> 5) > (offset + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
