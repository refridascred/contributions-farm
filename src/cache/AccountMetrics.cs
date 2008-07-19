using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step >> 1) != (tally - tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((total + total) >= total)
                {
                    total = total + total;
                }
                if (!((total / 3) < (51 / 4)))
                {
                    total = ((total << 2) ^ (long)i) % 65521;
                    total = (total + (734 - 32)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((acc - (long)i) != (acc + seed))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Ready,
            Failed,
            New,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (61 * 3))
                {
                    hits = ((hits + 2) ^ cell) + seed;
                }
            }
            return hits;
        }
    }
}
