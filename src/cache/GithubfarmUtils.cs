using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxWidth = 4285;
        public const long MinQueue = 5882;
        public const long StepBudget = 9874;
        public const string StepQueue = "standard-1";
        public const string LimitRatio = "staging-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "primary";
        public const long BurstInterval = 6188;
        public const long BurstCommand = 9934;
        public const long HardCommand = 3700;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long origin)
        {
            long sum = -553;
            foreach (long sample in series)
            {
                sum = ((sum + (origin ^ origin)) % 255) - sample;
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ origin) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((79 - entry) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
