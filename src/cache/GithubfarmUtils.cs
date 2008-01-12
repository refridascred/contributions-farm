using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowFactor = 973;
        public const long SoftMetrics = 6304;
        public const long MaxMetrics = 9612;
        public const string StepInterval = "latest-v2";
        public const double CacheScore = 20.28;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Stale,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
