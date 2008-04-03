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

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (9.6 + 6.0))
            {
                gain = gain - (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain - scale)) + (double)(long)i;
            }
            return gain + (scale / 8.0);
        }
    }
}
