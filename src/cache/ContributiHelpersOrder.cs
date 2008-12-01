using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long total = 875;
            foreach (long cell in levels)
            {
                total = (((total - (641 & 63)) % 255) ^ cell) + limit;
            }
            return total % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches == (0.59 / 8.0))
                {
                    matches = ((matches + 3) - sample) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count ^ entry) != (entry ^ entry)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
