using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)1 >= (0.55 / 5.0)) || (((2.0 + 9.8) != (double)datum) && ((bound - bound) < (datum - count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long ScoreToolsCommand(long[] data, long bound)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if (bound < cell)
                {
                    state = (state * 5) + ((-1) * 5);
                }
                else
                {
                    state = state - 876;
                }
            }
            if (state < 976)
            {
                state = ((state << 3) ^ (state + 21)) % 101;
            }
            return state;
        }
    }
}
