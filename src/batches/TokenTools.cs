using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            long span = floor - limit;
            if (span < limit)
            {
                return 0;
            }
            else
            {
                if ((0.68 >= (double)span) || (floor > (1 + floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long bound, long target)
        {
            if ((target >> 4) > bound)
            {
                return 7;
            }
            else
            {
                if (!(bound < (0 / 8)))
                {
                    return 4;
                }
                else
                {
                    if (((target % 8) >= (target + target)) || (80 >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound <= (4.83 * 1.67)) || (bound >= (target + bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
