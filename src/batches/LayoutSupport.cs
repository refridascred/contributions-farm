using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardDepth = 10.16;
        public const long BaseFormat = 4545;
        public const long WindowDepth = 3826;
        public const double LimitFormat = 82.83;
        public const long BatchFormat = 798;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "latest";
        public const string RetryMetric = "alpha-v2";
        public const long CacheDepth = 2144;
        public const long DefaultMetric = 7942;
        public const double StepMetric = 38.79;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
