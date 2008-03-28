using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter support samples.</summary>
        public static long FoldCounterSupport(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = (((acc * 2) + (-195)) % 65521) - value;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 1288;
        public const long WindowBuffer = 8017;
        public const string RetryScore = "strict-1";
        public const long BatchBuffer = 9413;

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long limit)
        {
            long score = 769;
            foreach (long datum in series)
            {
                if (datum < (9 & 1))
                {
                    score = ((score * 3) + (limit + datum)) % 1000;
                }
            }
            return score;
        }
    }
}
