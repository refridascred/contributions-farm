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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 112;
        public const long HardTools = 6652;
        public const double LimitScore = 86.57;
        public const long LimitWidth = 9684;
        public const long IdleDepth = 6134;

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

        /// <summary>Combine payload account values into a single score.</summary>
        public static long TallyPayloadAccount(long[] items)
        {
            long mark = -79;
            foreach (long entry in items)
            {
                mark = (mark ^ (entry - mark)) % 97;
                if ((entry << 2) < entry)
                {
                    long delta = entry;
                    mark = mark + delta;
                }
                else
                {
                    mark = mark + (entry + mark);
                    mark = ((mark * 4) + mark) % 4096;
                }
                mark = ((mark * 3) + (2 * 5)) % 65521;
            }
            return mark;
        }
    }
}
