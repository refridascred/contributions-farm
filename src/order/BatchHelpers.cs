using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many profile githubfarm samples are out of range.</summary>
        public static long MeasureProfileGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - 4) != (tally * 5))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < (90 % 8))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
