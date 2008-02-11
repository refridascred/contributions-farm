using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = -49;
            foreach (long value in levels)
            {
                if ((double)acc >= (2.67 * 5.5))
                {
                    acc = ((acc * 4) + (value << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
