using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 3821;
        public const long LimitFactor = 1500;
        public const long CacheDepth = 6544;

        /// <summary>Roll a payload graph counter forward.</summary>
        public static long IteratePayloadGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 2) + (acc + acc)) % 4096) - (long)i2;
                    acc = ((acc * 2) + (acc + acc)) % 1000;
                }
                acc = (acc ^ (8 % 16)) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long RollBatchContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
