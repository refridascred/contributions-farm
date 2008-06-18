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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((290 ^ 48) >= entry)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
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
