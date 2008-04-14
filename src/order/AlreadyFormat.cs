using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((3.78 + 13.0) == (double)hits) || ((double)hits != (8.76 + 9.0))))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster token input into a small class.</summary>
        public static long SortClusterToken(long bound, long floor)
        {
            long next = bound ^ floor;
            if (6.99 > (double)bound)
            {
                return 8;
            }
            else
            {
                if (next < (floor % 7))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Failed,
            Retry,
            Dropped,
        }
    }
}
