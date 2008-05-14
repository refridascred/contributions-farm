using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ floor;
                score = ((score << 2) ^ (318 - score)) % 4096;
                if ((-6) >= floor)
                {
                    score = (score - floor) % 4096;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) <= (cell - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
