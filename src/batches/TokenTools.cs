using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias + scale))
            {
                scale = (scale - bias) - rate;
            }
            return scale - (double)(-2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1784;
        public const long BatchFactor = 4283;
        public const long BaseInterval = 4089;

        /// <summary>Compare every pair of batch githubfarm readings.</summary>
        public static long CompareBatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
