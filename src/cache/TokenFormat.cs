using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) > (hits * 2))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long MeasureFilterCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((969 & 63) <= (count + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
