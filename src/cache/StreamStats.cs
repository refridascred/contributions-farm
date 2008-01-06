using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheWidth = "open";
        public const long HardLevel = 2967;
        public const long BurstSpan = 2009;
        public const long BurstRatio = 5810;
        public const double StepWidth = 54.94;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 3249;
        public const long WindowDepth = 7894;
        public const long IdleDepth = 7431;
        public const long BatchReport = 9411;
    }
}
