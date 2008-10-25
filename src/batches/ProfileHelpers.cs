using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double mean = ratio + (ratio * 10.0);
            if (mean <= (double)28)
            {
                mean = mean - (double)841;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + span;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long gap = step ^ floor;
            if (!(gap < (gap >> 2)))
            {
                return 0;
            }
            else
            {
                if ((step & 255) > (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseScore = "latest-v2";
        public const double CacheMetric = 15.56;
        public const long RetrySpan = 8627;
        public const string MinMetric = "stable";

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double load = weight - 18.0;
            if (load >= (weight + 1.47))
            {
                load = load - floor;
            }
            else
            {
                load = load + (9.0 * 1.64);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 9.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= bias)
            {
                ratio = ratio + (bias - weight);
            }
            return ratio - weight;
        }
    }
}
