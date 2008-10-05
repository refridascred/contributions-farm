using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitTimeout = 2527;
        public const string BatchBudget = "fallback-v2";
        public const long BatchGithubfarm = 7943;
        public const double BurstCount = 36.8;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
