using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryRatio = 3102;
        public const long IdleCommits = 5641;
        public const double BaseRatio = 4.48;
        public const long LimitCommits = 7956;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 1941;
        public const string IdleSize = "alpha-1";
        public const string MinBudget = "legacy";
        public const double IdleTimeout = 84.78;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((649 - tally) != (bound - (long)samples.Length))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
