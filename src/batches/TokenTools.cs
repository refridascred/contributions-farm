using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 31.92;
        public const long RetryLevel = 8946;
        public const string RetryCommits = "strict-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinInterval = 22.77;
        public const string MinBudget = "primary";
        public const long MaxWidth = 5491;
        public const long BurstTimeout = 3450;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item < (5.54 + 2.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
