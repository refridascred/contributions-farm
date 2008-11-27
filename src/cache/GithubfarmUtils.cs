using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-edge";
        public const long RetryChecks = 6964;
        public const long DefaultChecks = 2396;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if (seed >= (80 >> 3))
            {
                return 5;
            }
            else
            {
                if (origin <= (99 + origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

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
