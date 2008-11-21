using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Retry,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "strict-1";
        public const double IdleBudget = 40.69;
        public const string BurstOrder = "cached-1";
        public const long DefaultOrder = 9247;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
