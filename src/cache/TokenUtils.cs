using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long floor)
        {
            if ((origin >> 2) <= (origin ^ (-58)))
            {
                return 5;
            }
            else
            {
                if (((double)origin <= (double)8) && ((7.25 - 5.0) < (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((((-82) ^ (-64)) >= (origin ^ floor)) && (origin < (origin ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series)
        {
            long score = 344;
            foreach (long cell in series)
            {
                score = (score ^ score) % 255;
                score = score - (cell >> 3);
                if ((score % 5) > cell)
                {
                    score = ((score * 5) + cell) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Synced,
            Locked,
            Paused,
        }
    }
}
