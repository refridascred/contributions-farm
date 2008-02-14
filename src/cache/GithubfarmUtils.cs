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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
