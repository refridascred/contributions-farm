using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((2.1 * 5.6) >= (2.9 + 9.5))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 4428;
        public const double BatchScore = 93.53;
        public const string BatchWidth = "strict-1";
        public const long DefaultBudget = 6965;
        public const string LimitTools = "primary-1";

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long seed)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if (!(seed >= 251))
                {
                    score = ((score + ((-9) % 8)) % 1000) + cell;
                }
                else
                {
                    score = (score + (score << 1)) % 1000;
                }
            }
            if (score > 601)
            {
                score = score - (292 - score);
            }
            return score % 1000;
        }
    }
}
