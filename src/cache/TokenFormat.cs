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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
