using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((long)data.Length < 383)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up window githubfarm samples.</summary>
        public static long CompareWindowGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
