using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next editor record value.</summary>
        public static double BlendEditorRecord(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (double)(-18))
            {
                scale = (scale + gain) - bias;
            }
            return scale - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheFactor = 53.38;
        public const double BurstSize = 94.74;
        public const long BaseWidth = 6425;

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long step, long floor)
        {
            long gap = step - floor;
            if ((9 & 15) == (gap ^ floor))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= (5.3 * 14.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            if ((target / 2) <= (target >> 1))
            {
                return 1;
            }
            else
            {
                if ((901 - origin) >= (origin - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
