using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 4525;
        public const long SoftLevel = 9002;
        public const double SoftBudget = 68.64;
        public const long IdleTimeout = 7098;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long bound)
        {
            long acc = -514;
            foreach (long sample in series)
            {
                if ((acc & 7) > ((-20) ^ acc))
                {
                    acc = ((acc ^ (bound / 5)) % 97) ^ sample;
                }
                else
                {
                    acc = ((acc << 2) ^ (49 << 2)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first stats cache entry that matches the target.</summary>
        public static long SeekStatsCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
