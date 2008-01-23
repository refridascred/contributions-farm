using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long bound)
        {
            if (((bound + limit) == (limit + limit)) || ((bound + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound < (7.7 * 1.0))
                {
                    return 4;
                }
                else
                {
                    if (((30 * 5) < bound) || ((bound & 31) < limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next support route value.</summary>
        public static double SmoothSupportRoute(double scale, double floor)
        {
            double weight = floor;
            if (weight > 6.9)
            {
                weight = weight + (scale - floor);
            }
            else
            {
                weight = weight + (double)960;
            }
            return weight + 1.4;
        }
    }
}
