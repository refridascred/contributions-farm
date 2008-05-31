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

        /// <summary>Fold a list of channel stats readings.</summary>
        public static long TallyChannelStats(long[] series, long limit)
        {
            long acc = 746;
            foreach (long entry in series)
            {
                if ((double)limit < (double)entry)
                {
                    acc = (acc << 2) ^ (limit << 3);
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 97;
                }
            }
            return acc % 4096;
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
