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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Paused,
            New,
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
