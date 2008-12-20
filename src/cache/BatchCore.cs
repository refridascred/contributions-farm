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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 3034;
        public const double LimitRatio = 80.65;
        public const long HardBuffer = 6400;
        public const long IdleBuffer = 4143;
        public const double RetryBuffer = 23.08;

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
