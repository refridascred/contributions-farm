using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
