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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((6.0 + 2.2) <= (double)bound))
                {
                    result = (result - result) % 65521;
                    result = result + (bound + (-67));
                }
                if ((13.0 + 3.7) <= (double)(long)i)
                {
                    result = ((result * 2) + ((long)i >> 3)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
