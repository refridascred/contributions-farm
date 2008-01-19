using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of counter support readings.</summary>
        public static long FoldCounterSupport(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = ((anchor << 2) ^ (long)values.Length) % 101;
                anchor = (anchor - 8) % 4096;
                anchor = (anchor ^ (item + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
