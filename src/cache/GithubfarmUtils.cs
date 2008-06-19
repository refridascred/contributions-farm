using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepTimeout = 38.42;
        public const long RetryWidth = 5035;
        public const long RetryDepth = 6966;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Synced,
            New,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 3.89;
        public const double WindowCommits = 97.63;
        public const double CacheCommits = 39.34;
        public const double RetryCommits = 45.47;
        public const string BurstCommits = "staging-1";

        /// <summary>Count the window record entries that pass the check.</summary>
        public static long AuditWindowRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value & 1) != (tally & 255)) && (tally <= 254))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
