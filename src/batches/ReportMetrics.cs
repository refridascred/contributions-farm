using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinRatio = "legacy-v2";
        public const double BatchInterval = 89.5;
        public const long CacheLevel = 1178;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4817;
        public const double HardLevel = 86.51;
        public const long HardScore = 8112;
        public const long RetryFactor = 8652;
        public const long SoftRatio = 7700;
    }
}
