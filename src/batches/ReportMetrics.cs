using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account queue readings against a rule.</summary>
        public static long TallyAccountQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) > seen) && ((double)reading <= (5.0 / 5.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!!((hits + (-59)) < hits))
                {
                    hits = ((hits + 3) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long AuditSessionBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) == (cell & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
