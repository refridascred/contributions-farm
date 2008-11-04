using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Idle,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 8023;
        public const long BatchNotes = 8151;
        public const string RetryNotes = "strict-1";
        public const string SoftLevel = "fallback-v2";
    }
}
