using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long bound)
        {
            if ((offset + offset) != (bound & 15))
            {
                return 2;
            }
            else
            {
                if (((5 + 3) < bound) && ((bound / 3) > (offset & 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long DeriveLayoutBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum % 60)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
