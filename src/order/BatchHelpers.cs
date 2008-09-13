using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseTimeout = "primary-1";
        public const double BurstRatio = 13.69;
        public const long SoftRatio = 795;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
