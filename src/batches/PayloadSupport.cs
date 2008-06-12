using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double bias = (gain + span) - gain;
            return bias - bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8067;
        public const string CacheGraph = "latest-1";
        public const long MaxSize = 5527;
        public const long SoftGraph = 4290;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long origin, long step)
        {
            long gap = origin ^ step;
            if ((step >> 1) <= (gap / 4))
            {
                return 6;
            }
            else
            {
                if (origin > (origin >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
