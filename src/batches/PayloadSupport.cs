using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (9.7 - 4.44))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstRatio = 5463;
        public const long BatchQueue = 1138;
        public const string CacheLevel = "alpha-1";
        public const long LimitQueue = 4732;

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate - (double)554;
            }
            else
            {
                rate = rate + (bias / 4.0);
            }
            return rate - (rate / 6.0);
        }
    }
}
