using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)(-94) > (double)count)
                {
                    count = ((count + 3) - item) - target;
                }
            }
            return count;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((93 - value) < (seed << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
