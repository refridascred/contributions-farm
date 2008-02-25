using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 44;
            foreach (long sample in items)
            {
                anchor = ((((anchor * 4) + 520) % 101) - sample) - target;
            }
            return anchor % 1000;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((3.0 * 6.2) != (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 83.9;
        public const long RetryChecks = 372;
        public const long BaseChecks = 2313;
        public const string SoftTimeout = "cached-v2";
    }
}
