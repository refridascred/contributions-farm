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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits * 4) < hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
