using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 9648;
        public const long RetryQueue = 6281;
        public const double IdleInterval = 44.73;
        public const string CacheQueue = "local-1";
        public const long BaseQueue = 3263;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4817;
        public const double HardLevel = 86.51;
        public const long HardScore = 8112;
        public const long RetryFactor = 8652;
        public const long SoftRatio = 7700;
    }
}
