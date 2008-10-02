using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long carry = -2;
            foreach (long item in levels)
            {
                if ((carry + item) > (item + carry))
                {
                    carry = (carry - target) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 8767;
        public const long CacheScore = 3447;
        public const long MinDepth = 788;
        public const double RetryStream = 91.54;
        public const long BurstRatio = 3392;
    }
}
