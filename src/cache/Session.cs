using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Closed,
            Failed,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2691;
        public const double BurstTimeout = 26.42;
        public const long CacheOrder = 931;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Stale,
            Done,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Retry,
            Queued,
            Failed,
            Paused,
        }
    }
}
