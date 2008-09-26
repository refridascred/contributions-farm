using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double rate = bias - (double)40;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long limit)
        {
            long bound = origin + limit;
            if (((-449) ^ bound) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound > 15.0)
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
