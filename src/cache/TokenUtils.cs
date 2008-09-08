using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 4138;
        public const string MinLayout = "latest-1";
        public const double MaxLayout = 26.61;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Stale,
            Queued,
            Closed,
            Pending,
        }
    }
}
