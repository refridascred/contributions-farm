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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen > (5.0 / 9.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
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
