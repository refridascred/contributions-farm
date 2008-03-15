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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "local-1";
        public const long IdleBuffer = 8863;
        public const long BatchBuffer = 7366;
        public const double LimitBuffer = 33.11;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4817;
        public const double HardLevel = 86.51;
        public const long HardScore = 8112;
        public const long RetryFactor = 8652;
        public const long SoftRatio = 7700;
    }
}
