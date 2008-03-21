using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                if ((2.9 - 3.2) <= (double)value)
                {
                    acc = (acc ^ (value + (long)levels.Length)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
