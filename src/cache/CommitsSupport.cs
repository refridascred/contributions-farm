using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "fallback";
        public const long MaxSpan = 7659;
        public const long BurstTimeout = 2792;
        public const string BaseSession = "legacy";
        public const long BurstWidth = 5606;

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 2467;
        public const long HardProfile = 737;
        public const double WindowProfile = 6.4;
        public const long SoftCount = 8011;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 5356;
        public const string MinRatio = "fallback-edge";
        public const long CacheSize = 4342;
        public const long SoftChecks = 5649;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 4.69;
        public const double RetryLevel = 68.39;
        public const long CacheSpan = 4082;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Dropped,
            Done,
        }
    }
}
