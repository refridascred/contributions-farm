using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Pending,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 5899;
        public const long LimitRatio = 3325;
        public const string IdleCommand = "open-v2";
        public const double HardCommand = 27.39;
        public const double CacheSize = 8.06;
    }
}
