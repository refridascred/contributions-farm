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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 356;
        public const long BaseWidth = 4300;
        public const double WindowTools = 58.79;
        public const long BatchLevel = 22;
        public const long RetryCount = 4406;
    }
}
