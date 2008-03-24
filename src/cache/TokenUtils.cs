using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches * 4) < (867 - sample))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
