using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile account entries that pass the check.</summary>
        public static long AuditProfileAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count & 31) == (count - count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Failed,
            New,
            Done,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "cached-v2";
        public const long StepFilter = 907;
        public const long BaseRatio = 9402;
    }
}
