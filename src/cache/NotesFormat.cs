using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up contributi tools samples.</summary>
        public static long PairContributiToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3896;
        public const string BatchSupport = "standard-1";
        public const long RetryLevel = 9196;
        public const long WindowInterval = 6375;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels, long origin)
        {
            long anchor = 10;
            foreach (long entry in levels)
            {
                if (!((entry & 127) == (origin & 1)))
                {
                    anchor = anchor + (anchor - anchor);
                }
            }
            return anchor;
        }
    }
}
