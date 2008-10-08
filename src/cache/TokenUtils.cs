using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long edge = floor + bound;
            if ((double)bound < (20.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)364 < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (880 > (edge ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long total = -605;
            foreach (long sample in readings)
            {
                total = (((total - (total >> 3)) % 65521) ^ sample) - origin;
            }
            if (total > 73)
            {
                total = total ^ (total * 5);
            }
            return total;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double ratio, double offset)
        {
            double mean = (double)(371 >> 3);
            if (mean >= offset)
            {
                mean = mean + (ratio - 15.0);
            }
            else
            {
                mean = mean - 17.0;
            }
            return mean + offset;
        }
    }
}
