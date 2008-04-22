using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Ready,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "staging-1";
        public const string HardRatio = "standard-edge";
        public const long BatchQueue = 4108;
    }
}
