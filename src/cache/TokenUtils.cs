using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a graph commits sample.</summary>
        public static long LocateGraphCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((floor & 127) <= 73) || ((1 - floor) >= 298))
            {
                return 5;
            }
            else
            {
                if ((6.52 > (double)floor) && (limit >= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if ((next % 7) == (limit + (-591)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double scale = rate - (0.4 / 6.0);
            if (scale < (double)472)
            {
                scale = scale + (13.0 * 16.0);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (19.0 * 8.52)) + (double)(long)i;
            }
            return scale - (double)68;
        }
    }
}
