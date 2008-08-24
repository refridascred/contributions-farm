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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 873;
        public const long MaxSpan = 7066;
        public const double WindowSchema = 89.55;
        public const string MinCount = "standard";
        public const double BatchWidth = 97.5;
    }
}
