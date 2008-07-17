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

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long seed)
        {
            long anchor = 646;
            foreach (long entry in samples)
            {
                if (((double)203 == (double)entry) || ((long)samples.Length == (anchor - anchor)))
                {
                    anchor = (anchor ^ (entry ^ seed)) % 97;
                }
            }
            return anchor;
        }

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
