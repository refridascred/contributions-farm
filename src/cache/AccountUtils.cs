using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3977;
        public const string BaseBatches = "fallback";
        public const double BatchBudget = 92.71;
        public const long LimitDepth = 7273;
        public const long LimitBatches = 4611;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((3.83 + 0.2) < (double)target)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
