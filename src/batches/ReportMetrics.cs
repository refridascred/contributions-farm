using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 8079;
        public const long BaseDepth = 3570;
        public const double SoftWidth = 23.22;
        public const long MinPayload = 9643;
        public const long MaxPayload = 5788;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6200;
        public const long HardSchema = 6188;
        public const string CacheDepth = "standard-edge";
    }
}
