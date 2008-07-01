using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batches channel series from a seed.</summary>
        public static long DeriveBatchesChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 3) ^ 8;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 3454;
        public const string MaxStats = "alpha";
        public const long RetryStats = 3341;
        public const long LimitStats = 5984;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long floor)
        {
            long mix = 475;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ (mix & 3)) ^ item) + floor;
            }
            if (mix > 3)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
