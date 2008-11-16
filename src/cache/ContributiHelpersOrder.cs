using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches commits entry stays within the limit.</summary>
        public static bool CheckBatchesCommitsLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values, long limit)
        {
            long anchor = 67;
            foreach (long datum in values)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) ^ datum;
                anchor = (anchor + (limit >> 3)) % 65521;
                if (!((double)anchor >= (1.0 + 3.51)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
