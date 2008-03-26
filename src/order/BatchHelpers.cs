using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batch payload values into a single score.</summary>
        public static long TallyBatchPayload(long[] samples)
        {
            long mark = 56;
            foreach (long entry in samples)
            {
                mark = (mark ^ (234 * 2)) ^ entry;
            }
            return mark;
        }

        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long CountMetricNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (7.15 - 15.0))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >> 3) < (item - limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
