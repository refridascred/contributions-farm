using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double scale = offset;
            if (scale <= bias)
            {
                scale = scale - (offset - bias);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long limit)
        {
            long span = target - limit;
            if ((target % 12) == (span + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (5.58 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((span * 5) > (target + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
