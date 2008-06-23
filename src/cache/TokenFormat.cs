using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long bound)
        {
            long delta = floor - bound;
            if ((446 & 255) >= (delta / 9))
            {
                return 2;
            }
            else
            {
                if (delta <= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load - ratio;
            }
            else
            {
                load = load + (5.6 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
