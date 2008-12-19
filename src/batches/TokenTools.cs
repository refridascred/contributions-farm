using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4734;
        public const long DefaultOrder = 4607;
        public const long RetrySize = 7420;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
