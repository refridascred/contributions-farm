using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 9340;
        public const long BaseTimeout = 8686;
        public const string RetryContext = "standard-v2";
        public const double CacheCount = 18.38;
        public const double MinWidth = 49.14;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 2889;
        public const long IdleBudget = 3606;
        public const double StepChannel = 42.35;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches << 1) == (cell * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Failed,
            Done,
            Queued,
        }
    }
}
