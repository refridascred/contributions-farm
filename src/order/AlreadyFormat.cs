using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long DeriveBatchesEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc - 7) ^ (long)i2;
                }
                if ((13.0 - 3.29) < (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + (23 + step)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Dropped,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a checks tools value against two limits.</summary>
        public static long SortChecksTools(long seed, long limit)
        {
            if ((seed / 7) == (seed % 12))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) < seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
