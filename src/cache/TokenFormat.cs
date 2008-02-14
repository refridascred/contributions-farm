using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long sum = -2;
            foreach (long item in items)
            {
                sum = (((sum << 2) ^ (item - sum)) % 65521) - origin;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 69.33;
        public const double WindowQueue = 0.99;
        public const double DefaultQueue = 71.84;
        public const long StepBudget = 8533;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long target)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = (((score << 3) ^ (target + target)) % 4096) - value;
            }
            if (score > 48)
            {
                score = ((score * 3) + (157 ^ score)) % 65521;
            }
            return score % 1000;
        }
    }
}
