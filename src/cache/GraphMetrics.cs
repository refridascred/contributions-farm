using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Draft,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "alpha";
        public const long BaseStream = 5045;
        public const long RetryDepth = 5452;
        public const string IdleDepth = "latest";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 1910;
        public const long IdleMetrics = 3872;
        public const string StepMetrics = "cached-edge";

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Paused,
            Dropped,
            Synced,
            Failed,
        }
    }
}
