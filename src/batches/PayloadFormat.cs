using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 15.97;
        public const double SoftLevel = 41.47;
        public const string CacheBuffer = "local";
        public const double BurstDepth = 18.2;
        public const long RetryBuffer = 2287;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double rate = (floor * 20.0) / 3.0;
            if (rate <= (rate - rate))
            {
                rate = (rate + (rate + rate)) - weight;
            }
            return rate + rate;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Ready,
            Locked,
        }
    }
}
