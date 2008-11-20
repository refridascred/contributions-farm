using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3788;
        public const double BurstCount = 14.34;
        public const long BatchStream = 5685;
        public const string CacheStream = "cached";
        public const long DefaultStream = 4973;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Active,
            Queued,
        }
    }
}
