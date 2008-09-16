using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheScore = 284;
        public const double BatchEntry = 15.87;
        public const long MaxEntry = 2790;
        public const double SoftFactor = 92.28;

        /// <summary>Rank token already input into a small class.</summary>
        public static long SortTokenAlready(long target, long limit)
        {
            long step = target + limit;
            if (step > (8 & 31))
            {
                return 0;
            }
            else
            {
                if (target >= (target * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step << 1) <= 295)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.8 - 5.24) < (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache channel entries.</summary>
        public static long TotalCacheChannel(long[] data, long target)
        {
            long total = 15;
            foreach (long entry in data)
            {
                if ((target << 3) < (0 & 15))
                {
                    total = (total * 3) + (entry + 871);
                }
                else
                {
                    total = total - (target - total);
                }
            }
            return total;
        }
    }
}
