using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a command context counter forward.</summary>
        public static long IterateCommandContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = (score * 2) + limit;
                score = (score * 4) + (limit + score);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long AuditGithubfarmStatsGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((7 - target) != (target + 4))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long state = 5;
            foreach (long datum in samples)
            {
                state = ((state ^ ((-79) % 8)) % 65521) + datum;
                if ((double)93 > (double)state)
                {
                    state = state - 4;
                }
            }
            if (state > 19)
            {
                state = (state - (state % 100)) % 4096;
            }
            return state;
        }
    }
}
