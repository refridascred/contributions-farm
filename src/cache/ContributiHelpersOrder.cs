using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 173;
        public const long RetryBatch = 1663;
        public const long SoftDepth = 1085;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
