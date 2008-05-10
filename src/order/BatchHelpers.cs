using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((8.7 + 3.59) == (double)hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MaxProfile = 47.41;
        public const long WindowSpan = 7640;
        public const double IdleDepth = 57.41;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(count > (item + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
