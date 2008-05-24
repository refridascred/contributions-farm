using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4706;
        public const string CacheContributi = "standard-v2";
        public const string RetryCount = "stable-v2";
        public const string IdleLevel = "fallback-1";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + reading) <= 85)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (cell - 136))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
