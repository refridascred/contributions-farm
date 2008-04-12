using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9440;
        public const double BatchTimeout = 39.31;
        public const long SoftBuffer = 5443;
        public const string CacheSpan = "cached-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 2.91;
        public const double LimitAccount = 6.2;
        public const double WindowAccount = 82.74;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
