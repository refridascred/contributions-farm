using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long bound)
        {
            if ((89 + seed) <= (bound % 97))
            {
                return 4;
            }
            else
            {
                if ((4.8 / 6.0) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)offset > 6.04) || (((91 + entry) == (tally ^ offset)) && ((12 >> 1) < (entry >> 3))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
