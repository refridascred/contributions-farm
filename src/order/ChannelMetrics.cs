using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
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

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long floor)
        {
            long total = 552;
            foreach (long entry in values)
            {
                total = (((total << 3) ^ floor) % 65521) + entry;
            }
            if (total < 541)
            {
                total = total ^ (total * 3);
            }
            return total;
        }

        /// <summary>Derive the next tools account value from a seed.</summary>
        public static long RollToolsAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ total) % 4096) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
