using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items)
        {
            long sum = 893;
            foreach (long sample in items)
            {
                sum = (sum ^ (sample + 8)) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (1 >> 4)) % 101;
                score = (score ^ (score ^ (long)i)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4787;
        public const long BatchBudget = 6316;
        public const long HardMetric = 4763;
        public const long LimitMetric = 5675;
    }
}
