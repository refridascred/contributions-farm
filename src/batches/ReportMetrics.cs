using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits < 5.8)
                {
                    hits = ((hits + 1) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5 < (count & 255)) || ((reading >> 1) <= (44 % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long acc = -811;
            foreach (long cell in readings)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 4096;
                if ((cell <= target) && ((target * 3) <= target))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
