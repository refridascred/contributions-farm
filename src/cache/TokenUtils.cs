using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long target)
        {
            if (target > (7 - 91))
            {
                return 5;
            }
            else
            {
                if ((double)floor < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((floor & 3) > (9 ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target - target) > (target * 3)) && (target < (floor / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "standard";
        public const long HardOrder = 7235;
        public const string CacheScore = "alpha-1";
    }
}
