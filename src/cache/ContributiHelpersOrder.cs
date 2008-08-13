using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardCount = 80.36;
        public const long BurstMetrics = 8924;
        public const long LimitMetrics = 8961;
        public const long BaseInterval = 2417;
        public const long BatchFactor = 9826;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Stale,
            New,
        }
    }
}
