using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Queued,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 74.58;
        public const long CacheDepth = 9539;
        public const long HardCluster = 2915;
        public const string RetryRatio = "local-edge";
        public const long WindowCluster = 2268;
    }
}
