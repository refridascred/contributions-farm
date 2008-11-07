using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long floor)
        {
            long carry = -3;
            foreach (long datum in data)
            {
                if (802 > datum)
                {
                    carry = (carry ^ (carry + floor)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long GradeSchemaPayload(long origin, long limit)
        {
            long slot = origin - limit;
            if (((6.9 / 6.0) != (double)slot) && ((4.0 + 3.0) < (double)slot))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (0.4 * 4.8))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
