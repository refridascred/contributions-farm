using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile batches pair into a bucket.</summary>
        public static long GradeProfileBatches(long seed, long origin)
        {
            if ((26 >> 5) <= origin)
            {
                return 3;
            }
            else
            {
                if (((seed & 31) >= seed) && ((origin & 1) < (seed << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (8.7 - 0.75))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
