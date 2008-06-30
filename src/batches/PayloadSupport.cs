using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
