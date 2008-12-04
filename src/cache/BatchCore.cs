using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Idle,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(9.71 >= (double)hits) || (((3.75 * 19.0) <= (double)hits) || ((6 - hits) > 947)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
