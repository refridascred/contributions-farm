using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Synced,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
