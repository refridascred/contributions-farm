using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "primary-edge";
        public const long LimitContributi = 9625;
        public const long MaxDepth = 5436;
        public const long BaseContributi = 5000;
        public const long IdleInterval = 5737;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Idle,
            Stale,
            Dropped,
        }
    }
}
