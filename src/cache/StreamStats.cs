using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 96.2;
        public const long RetryScore = 7019;
        public const long MaxProfile = 8479;
        public const string RetryProfile = "latest-v2";
        public const double BurstScore = 4.59;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 200;
        public const long RetrySize = 8131;
        public const double BatchDepth = 10.62;
    }
}
