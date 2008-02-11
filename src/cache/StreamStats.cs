using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowInterval = 7118;
        public const long RetryAccount = 6752;
        public const long BaseRatio = 1221;
        public const double HardInterval = 51.27;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinDepth = 3180;
        public const double IdleDepth = 45.84;
        public const long BaseCount = 4602;
        public const long BurstWidth = 1319;
        public const string CacheBudget = "open-1";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
