using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 59.97;
        public const long MaxSession = 2772;
        public const long DefaultSession = 6546;

        /// <summary>Fold a list of command report readings.</summary>
        public static long CombineCommandReport(long[] data, long origin)
        {
            long state = 54;
            foreach (long cell in data)
            {
                state = ((state ^ (origin ^ origin)) % 4096) - cell;
            }
            if (state < 113)
            {
                state = ((state * 5) + (state & 31)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
