using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long next = origin - target;
            if (next <= (origin + target))
            {
                return 2;
            }
            else
            {
                if ((10.0 * 9.4) >= (double)next)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next order filter value from a seed.</summary>
        public static long DeriveOrderFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum << 3) ^ 259) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
