using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long TallyClusterCacheOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 31) <= (seed % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long AuditBatchCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) >= (reading + 462))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
