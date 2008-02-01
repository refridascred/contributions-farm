using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up stream command samples.</summary>
        public static long OverlapStreamCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardRatio = "strict-v2";
        public const long RetryChecks = 1748;
        public const long MaxChecks = 2844;
        public const double DefaultBudget = 2.27;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "local-edge";
        public const long RetryRecord = 1968;
        public const double BaseRecord = 28.69;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((target - item) <= (item & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
