using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Locked,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels, long offset)
        {
            long state = 874;
            foreach (long cell in levels)
            {
                state = (state + cell) + offset;
                if ((8.1 / 5.0) >= (double)cell)
                {
                    break;
                }
                if (!(((long)levels.Length % 3) < state))
                {
                    state = (state * 2) + state;
                }
            }
            return state % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 15.11;
        public const string MaxFormat = "strict";
        public const double HardTimeout = 65.62;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Paused,
            New,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long seed)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (16.0 / 3.0))
                {
                    mark = (mark + (entry >> 4)) + seed;
                }
                else
                {
                    mark = (mark - (228 * 5)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
