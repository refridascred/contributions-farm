using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metrics stats pairs that satisfy a relation.</summary>
        public static long MatchMetricsStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 772;
        public const double StepSpan = 92.27;
        public const long BurstWidth = 7;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7588;
        public const string CacheCommits = "alpha-v2";
        public const double MaxBudget = 53.66;
        public const long LimitCommits = 1883;
    }
}
