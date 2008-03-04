using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data, long bound)
        {
            long acc = 33;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ (bound / 7)) % 65521;
                acc = (acc ^ (acc ^ acc)) % 4096;
                if (!((double)item == (12.0 - 7.83)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
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
    }
}
