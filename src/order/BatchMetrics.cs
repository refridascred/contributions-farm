using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Ready,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item >= (6.97 - 17.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long bound)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = (((state << 3) ^ ((long)levels.Length ^ bound)) % 1000) ^ value;
            }
            return state % 97;
        }

        /// <summary>Match up order farm samples.</summary>
        public static long MatchOrderFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache session readings against a rule.</summary>
        public static long AuditCacheSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= 52)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (9.78 * 8.0)) && ((step & 7) != (reading + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
