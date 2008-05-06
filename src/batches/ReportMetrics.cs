using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long AuditGithubfarmAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((8.44 * 7.1) < (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 18.77;
        public const string DefaultDepth = "alpha-v2";
        public const long BatchLevel = 9151;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 5947;
        public const string RetrySize = "strict-edge";
        public const long MinCount = 2953;
        public const long HardStream = 5839;
    }
}
