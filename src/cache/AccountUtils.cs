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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4561;
        public const double MaxCommits = 56.8;
        public const long WindowWidth = 7089;
        public const long BurstCommits = 5891;
        public const long MinLevel = 4537;

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
