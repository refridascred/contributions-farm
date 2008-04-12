using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long carry = 38;
            foreach (long entry in samples)
            {
                if (88 <= (carry << 3))
                {
                    carry = carry + carry;
                    carry = (carry * 5) + origin;
                }
                if (!(carry < (carry ^ origin)))
                {
                    carry = (carry - entry) % 65521;
                }
                if (((entry >> 5) < (5 + 5)) && ((281 & 3) > (entry << 3)))
                {
                    carry = carry - (long)samples.Length;
                }
            }
            return carry % 97;
        }

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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Locked,
            Closed,
            Pending,
            Dropped,
        }
    }
}
