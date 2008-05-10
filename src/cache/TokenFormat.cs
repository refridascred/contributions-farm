using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long FoldRouteGithubfarm(long[] values)
        {
            long state = 7;
            foreach (long entry in values)
            {
                if ((state >> 1) > entry)
                {
                    state = (state - (423 ^ entry)) % 1000;
                }
                else
                {
                    state = state ^ (entry - entry);
                    state = ((state << 3) ^ (entry * 3)) % 101;
                }
                state = (state ^ (2 / 8)) % 101;
                if ((0 ^ state) < (entry + entry))
                {
                    state = ((state << 2) ^ (state - entry)) % 97;
                }
            }
            return state;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (span * 1.0)) + (double)(long)i;
            }
            return ratio - (double)(-89);
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long bound)
        {
            if (bound > limit)
            {
                return 1;
            }
            else
            {
                if (!((bound / 6) < bound))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 6.0) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
