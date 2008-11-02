using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (1.0 + 19.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes record samples.</summary>
        public static long FoldNotesRecord(long[] items, long limit)
        {
            long acc = 8;
            foreach (long entry in items)
            {
                if ((double)entry != (8.8 + 6.62))
                {
                    acc = acc + (entry << 2);
                }
            }
            if (acc > 182)
            {
                acc = (acc + (limit & 7)) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of cluster already readings.</summary>
        public static long CompareClusterAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((offset * 3) == (entry + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
