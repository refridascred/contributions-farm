using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "standard";
        public const string WindowGraph = "fallback";
        public const long RetryLevel = 595;
        public const long StepGraph = 2352;
        public const double CacheSize = 25.76;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
