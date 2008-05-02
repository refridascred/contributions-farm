using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 9068;
        public const string IdleWidth = "alpha-1";
        public const long RetryCache = 9712;
        public const long LimitLevel = 2509;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
                else
                {
                    carry = (carry + (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long acc = 95;
            foreach (long reading in values)
            {
                if ((double)reading >= (0.2 / 3.0))
                {
                    acc = acc + (407 & 127);
                }
            }
            return acc % 1000;
        }
    }
}
