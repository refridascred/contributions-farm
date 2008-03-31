using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "latest";
        public const string IdleFactor = "strict-v2";
        public const long CacheFarm = 326;
        public const long MinSize = 541;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5525;
        public const long LimitGraph = 6103;
        public const long StepGraph = 2701;
        public const double BaseGraph = 8.38;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
