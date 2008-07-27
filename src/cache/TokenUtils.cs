using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long limit)
        {
            long acc = 138;
            foreach (long sample in readings)
            {
                acc = ((acc - (9 - sample)) % 255) - limit;
            }
            return acc % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRatio = 5847;
        public const long BatchRecord = 4449;
        public const long BurstSize = 4585;
    }
}
