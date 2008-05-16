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

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7201;
        public const double MinDepth = 37.33;
        public const long CacheSpan = 7261;
        public const long HardBudget = 2458;
        public const long StepFilter = 2156;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
