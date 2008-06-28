using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 717;
            foreach (long item in values)
            {
                mix = (((mix << 3) ^ (target / 9)) % 4096) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long RollBatchesWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
