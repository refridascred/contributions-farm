using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3031;
        public const long RetryLevel = 5619;
        public const string MinCache = "primary-edge";
        public const string DefaultCache = "primary-edge";
    }
}
