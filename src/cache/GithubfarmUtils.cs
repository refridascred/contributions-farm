using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4329;
        public const double IdleScore = 32.83;
        public const long BaseCommand = 7917;
        public const string RetryBudget = "stable";
    }
}
