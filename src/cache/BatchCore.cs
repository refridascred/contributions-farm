using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long RankContributiToken(long offset, long seed)
        {
            long prev = offset ^ seed;
            if (!((prev ^ seed) < (prev - prev)))
            {
                return 5;
            }
            else
            {
                if ((seed + prev) == (seed + seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
