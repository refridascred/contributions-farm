using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxWidth = "latest";
        public const string CacheBatches = "fallback-v2";
        public const long WindowBatches = 6199;
        public const long BatchBatches = 7952;
        public const double DefaultBatches = 69.22;

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long CombineMetricCache(long[] levels)
        {
            long state = 625;
            foreach (long cell in levels)
            {
                if ((state / 6) <= (cell / 2))
                {
                    state = (state ^ (state << 2)) % 101;
                }
                else
                {
                    state = (state + (cell - cell)) % 101;
                }
            }
            if (state < 2)
            {
                state = state ^ (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a entry queue sample.</summary>
        public static long FindEntryQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
