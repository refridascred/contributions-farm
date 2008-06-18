using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 24) < value)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long step)
        {
            if (6.28 >= (double)floor)
            {
                return 5;
            }
            else
            {
                if (265 >= (step + floor))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
