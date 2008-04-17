using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 1316;
        public const long RetryBudget = 4057;
        public const long MaxInterval = 6873;
        public const long SoftDepth = 1891;
        public const long DefaultSpan = 3131;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 2936;
        public const long WindowNotes = 3502;
        public const long LimitNotes = 1351;
        public const long IdleNotes = 4856;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7433;
        public const double CacheTimeout = 4.47;
        public const long HardSize = 1950;
        public const long LimitBudget = 6691;
    }
}
