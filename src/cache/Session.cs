using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long total = 0;
            foreach (long item in values)
            {
                if ((-683) <= (total - 59))
                {
                    total = total - item;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 8901;
        public const long RetryBudget = 7956;
        public const long SoftWidth = 3939;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSize = 33.21;
        public const long HardCount = 2320;
        public const long HardLevel = 6549;
    }
}
