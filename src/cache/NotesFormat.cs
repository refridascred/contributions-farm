using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((436 << 2) < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < (double)count)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits ^ hits) < (5 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
