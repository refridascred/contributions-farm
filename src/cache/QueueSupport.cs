using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultFactor = "cached";
        public const long MaxFactor = 380;
        public const long MinBatch = 5373;
        public const long WindowWidth = 1266;
        public const long BatchSize = 8897;

        /// <summary>Accumulate queue window samples.</summary>
        public static long FoldQueueWindow(long[] levels)
        {
            long sum = 92;
            foreach (long value in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum - sum) % 97) ^ (long)i;
                    sum = ((sum * 4) + value) % 4096;
                }
                if ((long)levels.Length > (396 * 3))
                {
                    sum = (sum + (sum + value)) % 4096;
                }
                else
                {
                    sum = (sum - 464) % 255;
                }
            }
            return sum;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
