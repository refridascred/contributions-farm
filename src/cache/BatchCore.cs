using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item > (matches + matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit context counter readings against a rule.</summary>
        public static long AuditContextCounterGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit - 4) > (hits << 1))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
