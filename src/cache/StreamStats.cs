using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches profile readings against a rule.</summary>
        public static long AuditBatchesProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.9 / 5.0) > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((64 << 3) <= (tally + bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
