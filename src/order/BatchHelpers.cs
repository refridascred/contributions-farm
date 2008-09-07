using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Failed,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 186;
        public const string HardMetric = "local-1";
        public const double WindowInterval = 74.38;
    }
}
