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

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowWidth = "stable";
        public const double BurstEditor = 26.58;
        public const string BurstLevel = "primary-v2";
        public const double WindowEditor = 89.61;
        public const long LimitEditor = 4474;
    }
}
