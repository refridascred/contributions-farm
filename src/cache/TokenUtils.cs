using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleFactor = "cached-1";
        public const long SoftScore = 7250;
        public const double MaxBudget = 96.65;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((double)state <= (1.13 - 3.0)))
                {
                    state = (state * 3) + ((long)i ^ bound);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a commits format value against two limits.</summary>
        public static long ClassifyCommitsFormat(long bound, long bound2)
        {
            if (bound >= (731 - bound))
            {
                return 2;
            }
            else
            {
                if ((0 >= (bound2 + bound2)) || ((36 % 8) <= bound2))
                {
                    return 1;
                }
                else
                {
                    if ((4.6 / 4.0) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
