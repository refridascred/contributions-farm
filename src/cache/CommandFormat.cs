using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "primary";
        public const long CacheBatch = 6370;
        public const double LimitBatch = 26.4;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
