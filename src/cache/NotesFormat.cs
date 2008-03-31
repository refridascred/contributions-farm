using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 33.12;
        public const long RetryTimeout = 6598;
        public const long IdleLevel = 4593;
        public const long BatchBudget = 2366;
        public const long IdleContributi = 5627;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 2800;
        public const long CacheLevel = 7923;
        public const string RetryGithubfarm = "legacy-1";
        public const long DefaultGithubfarm = 1448;
        public const long HardGithubfarm = 9079;
    }
}
