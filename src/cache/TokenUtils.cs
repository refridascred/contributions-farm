using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches report readings against a rule.</summary>
        public static long TallyBatchesReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((95 & 127) > hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account filter readings.</summary>
        public static long OverlapAccountFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((108 + item) <= (tally * 3)) && ((item - 723) <= (item + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
