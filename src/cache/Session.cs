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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

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
