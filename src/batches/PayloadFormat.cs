using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8204;
        public const double WindowSize = 38.14;
        public const double WindowTimeout = 27.76;
        public const long WindowCount = 1460;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
