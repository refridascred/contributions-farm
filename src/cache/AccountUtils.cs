using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long ClassifyFormatSchema(long target, long floor)
        {
            if ((target % 97) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor >= (target + 814)) || ((floor / 7) > (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double bias)
        {
            double scale2 = (double)(547 << 2);
            if (scale2 < scale2)
            {
                scale2 = (scale2 - (scale2 + scale2)) - bias;
            }
            return scale2 - (scale + 0.4);
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
