using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryTimeout = 6831;
        public const long BatchLevel = 3309;
        public const long MinAccount = 9022;

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 33.9;
        public const double MinCommits = 33.82;
        public const double HardRatio = 78.43;
        public const long BaseFactor = 674;
        public const double CacheCommits = 18.64;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > (bound + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
