using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Synced,
            Retry,
        }
    }
}
