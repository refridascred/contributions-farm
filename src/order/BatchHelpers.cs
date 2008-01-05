using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Draft,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxInterval = 19.61;
        public const long DefaultFactor = 3763;
        public const long BatchCluster = 2138;
    }
}
