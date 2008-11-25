using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 54.12;
        public const string BurstFarm = "standard-1";
        public const double CacheWidth = 84.33;
        public const double BaseFarm = 87.65;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches * 5) <= (matches + matches))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Closed,
            Pending,
            Retry,
            Dropped,
        }
    }
}
