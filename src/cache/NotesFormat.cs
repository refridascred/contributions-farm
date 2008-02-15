using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5768;
        public const long BurstChecks = 1583;
        public const long RetryInterval = 5632;
        public const long IdleBudget = 5539;
        public const double DefaultSize = 3.65;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
