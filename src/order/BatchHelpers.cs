using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double BurstQueue = 83.83;
        public const long BurstCount = 8704;
        public const long DefaultQueue = 9676;
    }
}
