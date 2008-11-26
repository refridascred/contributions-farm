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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 6834;
        public const double LimitWidth = 86.74;
        public const long StepStream = 4878;
        public const long BurstStream = 2890;
    }
}
