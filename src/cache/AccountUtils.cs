using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((416 - target) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
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
