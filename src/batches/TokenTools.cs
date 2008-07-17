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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long seed)
        {
            long state = -38;
            foreach (long cell in series)
            {
                if ((double)seed != (double)669)
                {
                    state = (state - (cell * 4)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
