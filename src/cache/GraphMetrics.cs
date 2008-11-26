using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Idle,
            Failed,
            Draft,
            New,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 2861;
        public const long IdleDepth = 1565;
        public const long SoftEntry = 7077;
        public const double HardTimeout = 71.16;
    }
}
