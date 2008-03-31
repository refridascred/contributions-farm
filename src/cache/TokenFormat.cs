using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitBudget = 77.13;
        public const string SoftContext = "standard-1";
        public const long DefaultContext = 6882;
        public const long CacheLevel = 5874;
        public const long BurstContext = 507;

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 269;
            foreach (long cell in samples)
            {
                mark = (mark ^ (676 << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + (7 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long DeriveCommitsContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - ((long)i % 100)) % 97;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
