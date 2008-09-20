using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Draft,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 21.13;
        public const long HardRatio = 3066;
        public const string BatchWidth = "staging";
        public const long RetryCount = 8337;
        public const long BurstToken = 8656;
    }
}
