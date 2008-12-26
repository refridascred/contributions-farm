using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double floor)
        {
            double mean = rate;
            if (mean > (double)49)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + floor;
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 3673;
        public const string BaseSpan = "local";
        public const double CacheSpan = 4.02;
        public const long LimitMetric = 4090;
        public const long RetryWidth = 9386;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 83.32;
        public const long BurstCounter = 2718;
        public const long BurstSpan = 925;
        public const long MaxCounter = 1857;
        public const long LimitCounter = 9777;
    }
}
