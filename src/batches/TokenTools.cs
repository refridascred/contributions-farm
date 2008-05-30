using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = ((score - (score * 4)) % 101) ^ sample;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long bound2)
        {
            if ((1.68 - 8.0) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((bound2 << 3) < (bound2 + bound2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((double)matches < (7.72 + 5.9)) || ((matches + matches) <= matches)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
