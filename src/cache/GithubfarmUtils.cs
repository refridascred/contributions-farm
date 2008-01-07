using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 15.62;
        public const long MaxLevel = 6215;
        public const long LimitQueue = 6238;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 5756;
        public const double MinTimeout = 17.5;
        public const long MinCount = 5283;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((17.0 * 16.0) != (double)carry))
                {
                    carry = ((carry << 3) ^ (origin * 5)) % 101;
                }
                carry = carry - (carry - carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
