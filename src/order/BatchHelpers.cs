using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 960;
            foreach (long reading in series)
            {
                result = (result + (result - result)) - reading;
            }
            if (result < 32)
            {
                result = (result * 5) + (result % 2);
            }
            return result;
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
