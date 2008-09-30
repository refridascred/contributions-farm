using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long TallyCommitsPayloadOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 4) != (step - 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long step)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = ((total - (step % 64)) % 97) ^ item;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long SeekClusterNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
