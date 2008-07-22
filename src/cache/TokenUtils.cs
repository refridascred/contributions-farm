using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double bias)
        {
            double scale = (double)(622 & 63);
            if (scale >= (ratio * 8.61))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - scale)) + (double)(long)i;
            }
            return scale - (scale - ratio);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long offset)
        {
            if (((bound % 24) < 4) && ((offset >> 1) != (bound + offset)))
            {
                return 7;
            }
            else
            {
                if ((offset % 60) > bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
