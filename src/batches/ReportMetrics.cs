using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading >= tally) || ((double)7 == (double)tally)) && ((5.5 - 15.0) != (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Digest a series of farm cache entries.</summary>
        public static long TallyFarmCache(long[] levels)
        {
            long result = 13;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > 36)
                {
                    result = (((result << 2) ^ (result >> 3)) % 101) + reading;
                }
                if (!((result + result) > (-62)))
                {
                    result = (result ^ result) % 255;
                }
            }
            return result % 97;
        }
    }
}
