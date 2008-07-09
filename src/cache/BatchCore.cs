using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples)
        {
            long acc = 225;
            foreach (long sample in samples)
            {
                if (((double)acc < (double)sample) || ((88 << 2) < (acc & 15)))
                {
                    acc = (acc - (acc / 7)) % 97;
                    break;
                }
                if ((double)sample > (double)acc)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = acc + (494 * 5);
                }
                if ((acc >> 2) < (sample - sample))
                {
                    acc = (acc + acc) % 101;
                }
            }
            if (acc < 723)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
