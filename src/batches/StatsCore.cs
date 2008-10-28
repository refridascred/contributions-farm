using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 9.13;
        public const long LimitSupport = 7666;
        public const long CacheSupport = 6443;
        public const long HardFactor = 482;
        public const long DefaultCount = 5010;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
