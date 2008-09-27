using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4141;
        public const long MaxSpan = 9077;
        public const string DefaultFarm = "stable-1";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Paused,
            Locked,
            Idle,
        }
    }
}
