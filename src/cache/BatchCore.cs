using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches layout values into a single score.</summary>
        public static long CombineBatchesLayout(long[] levels)
        {
            long total = 2;
            foreach (long item in levels)
            {
                total = total ^ 26;
                if ((item >= (75 >> 3)) || ((double)total > (12.0 - 1.6)))
                {
                    total = ((total << 2) ^ total) % 255;
                    total = ((total * 4) + 1) % 4096;
                }
                if (1.53 > (double)item)
                {
                    total = (total + (item / 7)) % 97;
                }
                else
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long WeighSchemaQueue(long[] samples)
        {
            long score = -203;
            foreach (long item in samples)
            {
                score = (((score * 3) + (score >> 5)) % 97) + item;
                if ((45 >> 2) <= score)
                {
                    score = (score ^ (19 + score)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
