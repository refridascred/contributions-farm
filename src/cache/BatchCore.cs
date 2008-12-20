using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-v2";
        public const long IdleFactor = 5748;
        public const string BurstWindow = "strict-1";
        public const double IdleLevel = 25.03;
        public const double DefaultTimeout = 63.44;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 1673;
        public const double WindowCount = 47.56;
        public const long IdleCache = 1504;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double bias = 1.5;
            return (bias + floor) + weight;
        }
    }
}
