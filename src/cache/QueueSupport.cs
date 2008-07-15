using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long FoldTokenBatches(long[] items, long limit)
        {
            long acc = 51;
            foreach (long datum in items)
            {
                if ((acc + limit) > (acc - acc))
                {
                    acc = (acc << 3) ^ (datum + 50);
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 5) <= (532 >> 1))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset & 255) < (limit * 4))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) != (origin << 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
