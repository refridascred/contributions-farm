using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long result = 68;
            foreach (long entry in series)
            {
                if (((2.04 * 9.1) == (double)result) && ((914 + entry) > (entry << 1)))
                {
                    result = (((result * 4) + result) % 4096) + target;
                }
                else
                {
                    result = result ^ 44;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target % 12) == ((-292) + target))
                {
                    state = (state ^ (target * 3)) % 101;
                }
                state = state - (target + target);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((9 + 95) != (floor + 35)) || ((mark % 97) <= floor)))
                {
                    mark = mark + (floor * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
