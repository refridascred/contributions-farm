using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 7;
            foreach (long datum in data)
            {
                mix = (mix + datum) + seed;
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSpan = 3073;
        public const long DefaultBatch = 3034;
        public const long WindowCount = 4906;
    }
}
