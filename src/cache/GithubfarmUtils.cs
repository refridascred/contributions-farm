using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] values, long offset)
        {
            long state = 10;
            foreach (long sample in values)
            {
                state = state + (offset + sample);
            }
            return state % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 4) >= 941)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                state = (state ^ (state << 3)) % 1000;
                if ((5.5 * 15.0) == (double)state)
                {
                    state = state + (value + 10);
                }
            }
            return state;
        }
    }
}
