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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1.0 / 2.0) <= (double)floor)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
