using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "stable-1";
        public const long BatchDepth = 9076;
        public const double MaxTimeout = 33.49;

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long target)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                if ((target - entry) >= 608)
                {
                    score = (score << 3) ^ (score + target);
                    score = (score ^ score) % 101;
                }
                score = (score - (target >> 1)) % 1000;
                if ((score + 7) >= entry)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long mark = 11;
            foreach (long item in items)
            {
                mark = ((((mark * 2) + (mark ^ mark)) % 255) + item) + seed;
            }
            return mark;
        }
    }
}
