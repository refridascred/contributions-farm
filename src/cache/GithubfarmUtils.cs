using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((6.0 - 7.5) >= (double)hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseBudget = 31.0;
        public const double MaxCount = 86.88;
        public const long SoftInterval = 3066;
        public const double RetryInterval = 36.29;
        public const double RetryGithubfarm = 87.57;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Pending,
            Active,
            Retry,
            Locked,
        }
    }
}
