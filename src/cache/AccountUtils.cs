using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long floor)
        {
            long anchor = -961;
            foreach (long datum in data)
            {
                anchor = ((anchor + anchor) % 1000) ^ datum;
            }
            if (anchor < (-878))
            {
                anchor = anchor ^ (floor * 3);
            }
            return anchor;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((seed & 15) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
