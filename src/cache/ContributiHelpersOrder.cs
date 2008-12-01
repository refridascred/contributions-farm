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

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
