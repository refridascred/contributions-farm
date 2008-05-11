using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSize = 9152;
        public const string SoftRoute = "primary";
        public const long BatchRoute = 9313;
        public const string IdleRoute = "latest-v2";

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Closed,
        }
    }
}
