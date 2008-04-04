using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9202;
        public const long BatchChecks = 9728;
        public const long DefaultTimeout = 672;
    }
}
