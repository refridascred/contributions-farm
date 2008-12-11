using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the window order series from a seed.</summary>
        public static long RollWindowOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 38.42;
        public const double RetryWindow = 31.42;
        public const long CacheTimeout = 4398;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry << 3) ^ (carry & 1)) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
