using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryWidth = 7.89;
        public const string MinScore = "standard-v2";
        public const long StepSpan = 8709;
        public const long WindowChecks = 6144;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Queued,
            Stale,
            Pending,
            Done,
        }

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
