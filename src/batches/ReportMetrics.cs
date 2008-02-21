using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2499;
        public const long BaseInterval = 2129;
        public const string HardFormat = "open-v2";
        public const long BurstBudget = 5316;

        /// <summary>Check that every token support entry stays within the limit.</summary>
        public static bool GuardTokenSupportRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((227 << 1) < (count & 7)))
                {
                    count = ((count + 1) + datum) - origin;
                }
            }
            return count;
        }
    }
}
