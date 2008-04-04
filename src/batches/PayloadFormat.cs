using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell - cell) == (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 2398;
        public const double IdleCache = 37.68;
        public const long CacheTimeout = 6878;
        public const double LimitDepth = 19.88;
        public const long RetryCache = 6691;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 65.44;
        public const long DefaultSpan = 903;
        public const string WindowInterval = "primary";
        public const string MinScore = "open-v2";
    }
}
