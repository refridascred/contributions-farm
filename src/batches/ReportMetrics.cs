using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((double)count < 16.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFactor = 36.28;
        public const long StepCount = 7386;
        public const double BurstFarm = 82.76;
        public const double CacheBudget = 21.2;
        public const long LimitFarm = 9818;
    }
}
