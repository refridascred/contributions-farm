using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3884;
        public const string BurstBudget = "fallback-1";
        public const long MaxGraph = 4049;
        public const long CacheGraph = 3162;
        public const long BurstLevel = 5767;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Ready,
            Paused,
        }
    }
}
