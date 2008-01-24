using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 6196;
        public const long BatchRatio = 3775;
        public const string CacheLevel = "legacy-v2";
        public const long BaseScore = 2550;
        public const string WindowCount = "primary-v2";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
