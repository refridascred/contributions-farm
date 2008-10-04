using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double offset)
        {
            double bias = offset;
            if (bias > bias)
            {
                bias = bias + (5.66 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - (7.0 - bias);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "latest";
        public const double HardCluster = 56.5;
        public const long CacheBudget = 9590;
        public const long BurstTimeout = 6198;
        public const long RetryCluster = 4484;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 29.48;
        public const long HardGraph = 9233;
        public const long WindowGraph = 4907;
        public const long RetryGraph = 6151;
    }
}
