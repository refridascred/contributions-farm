using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultLevel = 1788;
        public const long IdleFactor = 4422;
        public const string SoftTimeout = "cached-1";
        public const long BatchCluster = 9622;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryInterval = 43.24;
        public const double RetryBuffer = 75.76;
        public const double CacheBuffer = 50.91;
        public const long HardSpan = 1309;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Queued,
            Pending,
            New,
            Done,
        }
    }
}
