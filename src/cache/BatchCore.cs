using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSpan = 3833;
        public const long CacheToken = 9100;
        public const string BaseToken = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Iterate the report support series from a seed.</summary>
        public static long IterateReportSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.4 * 9.9) <= (double)entry)
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
