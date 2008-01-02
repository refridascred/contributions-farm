using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (17.0 >= (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (48 < (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 1334;
        public const long BaseToken = 3967;
        public const string MinToken = "stable-edge";
        public const long SoftToken = 1195;
    }
}
