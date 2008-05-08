using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score + ((long)i % 5)) % 4096) - value;
                }
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9250;
        public const long MaxGraph = 8767;
        public const string RetrySpan = "primary-v2";
    }
}
