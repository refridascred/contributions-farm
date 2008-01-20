using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 30.52;
        public const double BurstScore = 60.38;
        public const double BaseInterval = 85.45;
        public const long LimitChecks = 3053;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long bound)
        {
            if (((double)origin >= (3.92 + 9.69)) || ((bound + bound) >= origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin <= (6.0 - 4.52)) && ((bound * 3) < origin))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) != (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series)
        {
            long score = 205;
            foreach (long sample in series)
            {
                if ((double)score != (0.5 * 8.7))
                {
                    score = (score + (sample + score)) % 1000;
                }
                score = (score + (sample % 16)) % 97;
                if ((170 + score) > sample)
                {
                    score = (score * 4) + (sample - score);
                }
                else
                {
                    score = ((score << 2) ^ 74) % 4096;
                }
            }
            return score;
        }
    }
}
