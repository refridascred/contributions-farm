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

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long TallyFarmFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) >= (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
