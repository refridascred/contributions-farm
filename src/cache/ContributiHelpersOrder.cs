using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
