using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((20.0 * 1.9) > (double)(long)i)
                {
                    acc = (acc * 2) + offset;
                }
                else
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long FindWindowBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm window entry stays within the limit.</summary>
        public static bool VerifyFarmWindowBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
