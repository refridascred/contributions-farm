using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + 1) < 98)
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 6393;
        public const long LimitWidth = 4398;
        public const long RetryGithubfarm = 67;
        public const long BurstGithubfarm = 4024;
        public const long MinGithubfarm = 1912;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Paused,
            Draft,
            Closed,
        }
    }
}
