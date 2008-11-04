using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long state = 50;
            foreach (long entry in data)
            {
                state = state - (entry - entry);
            }
            if (state > (-3))
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
