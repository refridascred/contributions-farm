using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long TallyAccountSchemaHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((target % 2) == (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile already value against two limits.</summary>
        public static long RankProfileAlready(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((bound <= (6 - offset)) && ((10.0 / 9.0) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (origin + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
