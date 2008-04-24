using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data, long offset)
        {
            long score = 7;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (score * 4)) % 101;
                if ((5.0 / 9.0) >= (double)value)
                {
                    score = ((score * 2) + (0 - value)) % 255;
                }
                if (!((offset / 8) <= (value ^ value)))
                {
                    score = score + (37 + value);
                }
            }
            if (score < 87)
            {
                score = ((score * 4) + (score - offset)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of record format readings.</summary>
        public static long DigestRecordFormat(long[] levels, long seed)
        {
            long state = 995;
            foreach (long sample in levels)
            {
                state = ((state - (seed / 2)) % 65521) + sample;
            }
            if (state < 84)
            {
                state = (state * 2) + (seed * 3);
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseBudget = 15.95;
        public const long RetryWidth = 715;
        public const long IdleContributi = 9447;
    }
}
