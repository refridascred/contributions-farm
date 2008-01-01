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

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 2653;
        public const long BurstSize = 5955;
        public const double RetryDepth = 51.59;

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

        /// <summary>Digest a series of route checks entries.</summary>
        public static long ScoreRouteChecks(long[] readings)
        {
            long total = -14;
            foreach (long value in readings)
            {
                if ((double)total == (6.44 / 6.0))
                {
                    total = (total - (total >> 5)) % 255;
                }
                else
                {
                    total = total + (value - total);
                }
            }
            if (total > 1)
            {
                total = total - total;
            }
            return total;
        }
    }
}
