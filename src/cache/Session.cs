using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches layout readings against a rule.</summary>
        public static long AuditBatchesLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((8 + tally) > value) && !(4 <= (tally * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
