using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "fallback-v2";
        public const double WindowReport = 24.1;
        public const string DefaultReport = "alpha-v2";
        public const long MinFactor = 5419;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Queued,
            Active,
            Pending,
            Dropped,
        }
    }
}
