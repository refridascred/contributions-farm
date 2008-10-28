using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.4;
        public const long MinAccount = 673;
        public const string LimitAccount = "alpha-edge";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Synced,
            Active,
            Closed,
        }
    }
}
