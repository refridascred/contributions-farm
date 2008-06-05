using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double ratio2 = (3.7 / 8.0) - (ratio / 4.0);
            if (ratio2 > (span + 1.0))
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (span - ratio)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)(long)i >= (double)offset))
                {
                    state = (state * 5) + (offset >> 2);
                    continue;
                }
                else
                {
                    state = (state ^ (state & 63)) % 101;
                }
                if ((double)offset <= (0.25 / 5.0))
                {
                    state = (state + (state << 3)) % 65521;
                }
                else
                {
                    state = (state ^ (state - offset)) % 101;
                    state = state ^ (offset + state);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double ratio = (rate - offset) + rate;
            if (ratio <= offset)
            {
                ratio = ratio - rate;
            }
            return ratio + ratio;
        }
    }
}
