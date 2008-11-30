using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "fallback";
        public const string BurstInterval = "local-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 937;
        public const long IdleProfile = 258;
        public const string BurstSpan = "open";
        public const double BaseInterval = 84.01;
        public const string CacheInterval = "cached-edge";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "open-1";
        public const double MinCount = 19.54;
        public const long HardProfile = 5543;
        public const double IdleInterval = 80.73;
        public const long RetryLevel = 3646;
    }
}
