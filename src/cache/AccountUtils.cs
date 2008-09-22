using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "fallback-1";
        public const double MinCluster = 3.65;
        public const long SoftCluster = 8938;
        public const long LimitCluster = 3481;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Closed,
            Locked,
            Stale,
        }
    }
}
