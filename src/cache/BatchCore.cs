using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultLevel = "standard-v2";
        public const long WindowSize = 5920;
        public const double BaseSpan = 65.65;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1629;
        public const long WindowInterval = 6522;
        public const long LimitStream = 3052;
        public const long DefaultRatio = 8042;

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double rate = (bias - bias) * 1.0;
            if (rate >= scale)
            {
                rate = rate - bias;
            }
            return rate + (double)99;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
