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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 683;
        public const string StepCluster = "local-edge";
        public const string BurstSize = "cached";
        public const long HardWidth = 6993;

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
