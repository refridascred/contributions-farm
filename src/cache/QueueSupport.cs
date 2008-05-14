using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxInterval = 9040;
        public const string LimitInterval = "open-v2";
        public const long HardWidth = 6297;
        public const long CacheGithubfarm = 7992;
        public const string CacheBudget = "stable-v2";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }
    }
}
