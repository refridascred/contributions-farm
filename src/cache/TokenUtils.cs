using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format already entries.</summary>
        public static long ScoreFormatAlready(long[] levels)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if (!((double)score >= 4.19))
                {
                    score = (score - (score * 2)) % 97;
                    score = (score ^ 54) % 255;
                }
                if (((score + score) > (value / 6)) && ((double)value != (5.35 * 0.6)))
                {
                    score = ((score * 3) + ((long)levels.Length - score)) % 4096;
                }
                else
                {
                    score = (score * 3) + score;
                }
            }
            if (score > 16)
            {
                score = ((score << 2) ^ (score / 5)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7832;
        public const long StepContext = 2457;
        public const double CacheBudget = 34.03;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples, long step)
        {
            long sum = 33;
            foreach (long sample in samples)
            {
                sum = ((sum - step) % 1000) ^ sample;
                if (((6.52 * 18.0) < (double)sum) || (sum < (sum + sum)))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
