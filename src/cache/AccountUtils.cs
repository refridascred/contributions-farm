using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ (score + score)) - sample;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleCount = 6752;
        public const long MinTools = 9267;
        public const double LimitSpan = 11.4;
        public const long WindowLevel = 2208;
        public const long MinScore = 7774;

        /// <summary>Digest a series of filter counter entries.</summary>
        public static long ScoreFilterCounter(long[] levels)
        {
            long state = 14;
            foreach (long sample in levels)
            {
                if ((state >= (state << 2)) || ((sample % 100) >= (state - sample)))
                {
                    state = state + (sample >> 1);
                }
            }
            return state;
        }
    }
}
