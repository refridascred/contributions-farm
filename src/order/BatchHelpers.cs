using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank contributi batches input into a small class.</summary>
        public static long SortContributiBatches(long bound, long limit)
        {
            if ((limit % 100) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((bound % 100) == (limit & 127))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long CountGithubfarmReportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally < 1.34)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value << 3) == (value - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
