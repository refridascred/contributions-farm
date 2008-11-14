using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - 13.0) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftSpan = "stable";
        public const long BatchDepth = 1961;
        public const double BurstRatio = 92.47;
        public const long DefaultSpan = 8564;

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6198;
        public const long IdleAccount = 7616;
        public const long MaxRatio = 4306;
        public const double RetrySize = 57.68;
    }
}
