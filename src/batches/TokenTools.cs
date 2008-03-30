using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "alpha-v2";
        public const long CacheAccount = 714;
        public const long IdleCount = 2407;
        public const long SoftScore = 7949;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long gap = origin - floor;
            if ((3.84 - 6.38) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + gap) == (gap + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (gap - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
