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

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 42.1;
        public const long BurstBudget = 2492;
        public const string CacheCount = "latest-edge";
    }
}
