using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long bound)
        {
            long edge = step - bound;
            if (!((step & 15) == (edge - bound)))
            {
                return 7;
            }
            else
            {
                if ((50 ^ step) < (bound + step))
                {
                    return 3;
                }
                else
                {
                    if (step < edge)
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

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long limit)
        {
            if (origin <= (origin / 2))
            {
                return 8;
            }
            else
            {
                if (18.0 <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long MatchFilterContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
