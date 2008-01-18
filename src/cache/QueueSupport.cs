using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)seed < (4.49 * 5.5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches context readings.</summary>
        public static long PairBatchesContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 2) != (seen >> 1)) && (seen < (origin + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
