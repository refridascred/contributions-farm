using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long FoldBatchBuffer(long[] samples, long bound)
        {
            long result = 75;
            foreach (long item in samples)
            {
                result = ((((result << 2) ^ result) % 101) + item) - bound;
                result = (result - (result * 2)) % 97;
                if ((double)result == (0.34 / 5.0))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Audit editor cluster readings against a rule.</summary>
        public static long CountEditorClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum - count) < datum) && (datum > (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) <= (datum - hits))
                {
                    hits = hits + 1;
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
