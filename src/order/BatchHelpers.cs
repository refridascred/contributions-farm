using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long target)
        {
            long acc = 413;
            foreach (long entry in values)
            {
                acc = (acc - (entry * 4)) % 97;
                if (((double)entry == (9.0 + 14.0)) || ((2.5 - 2.2) <= (double)entry))
                {
                    acc = (acc * 2) + target;
                }
                else
                {
                    acc = (acc - (acc + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
