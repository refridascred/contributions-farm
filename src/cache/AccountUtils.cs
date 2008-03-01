using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseCount = 57.02;
        public const double MaxSize = 43.07;
        public const long HardFactor = 176;
        public const long MinBuffer = 8173;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Stale,
            Failed,
            Idle,
        }
    }
}
