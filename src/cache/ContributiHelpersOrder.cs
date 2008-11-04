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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
