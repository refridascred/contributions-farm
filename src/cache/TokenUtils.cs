using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double ratio = scale * 14.0;
            if (ratio > (ratio + ratio))
            {
                ratio = (ratio + scale) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (scale - 3.3)) + (double)(long)i;
            }
            return ratio + (scale * 8.79);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
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
