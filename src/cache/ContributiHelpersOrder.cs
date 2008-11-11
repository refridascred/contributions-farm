using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a schema counter sample.</summary>
        public static long FindSchemaCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest-edge";
        public const long BatchBatches = 7230;
        public const long SoftBatches = 3611;
        public const string RetryBatches = "staging-1";
    }
}
