using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally - 73) < (91 + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] series)
        {
            long carry = 94;
            foreach (long sample in series)
            {
                carry = ((carry + (carry - carry)) % 4096) ^ sample;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)limit > 12.0)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
