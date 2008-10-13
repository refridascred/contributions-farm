using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardScore = 9952;
        public const double RetryGraph = 22.4;
        public const long StepGraph = 300;
        public const double CacheScore = 30.03;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Offset { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
