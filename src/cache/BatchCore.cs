using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitSpan = 7.67;
        public const string BatchLevel = "primary-v2";
        public const long BatchInterval = 4668;
        public const long MinLevel = 813;
        public const long DefaultAlready = 7284;
    }
}
