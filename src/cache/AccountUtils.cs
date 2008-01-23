using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
