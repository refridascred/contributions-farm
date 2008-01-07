using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
