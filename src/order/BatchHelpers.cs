using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading >= (reading + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels, long offset)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                total = (((total << 2) ^ (67 + offset)) % 101) ^ entry;
            }
            if (total > 81)
            {
                total = (total + (total + offset)) % 101;
            }
            return total;
        }

        /// <summary>Audit entry contributi readings against a rule.</summary>
        public static long TallyEntryContributiGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally % 2) <= tally)
                {
                    tally = ((tally + 2) - reading) - step;
                }
            }
            return tally;
        }
    }
}
