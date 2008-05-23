using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Done,
            Failed,
            New,
            Idle,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Done,
            Failed,
            New,
        }
    }
}
