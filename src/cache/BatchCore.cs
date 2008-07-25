using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 63;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value << 1);
            }
            return score;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long step)
        {
            long offset = bound ^ step;
            if ((step >> 1) <= bound)
            {
                return 2;
            }
            else
            {
                if ((offset * 2) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (3.6 - 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context batches sample.</summary>
        public static long LocateContextBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 2) ^ (2 - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
