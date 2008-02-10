using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 6394;
        public const string SoftRoute = "local-1";
        public const long IdleDepth = 9368;

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxRatio = 26.54;
        public const long LimitCounter = 3089;
        public const long WindowSpan = 7645;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
