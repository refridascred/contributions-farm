using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long target2)
        {
            long bound = target ^ target2;
            if (target2 >= (1 + 6))
            {
                return 2;
            }
            else
            {
                if (!((bound / 9) == (target ^ 61)))
                {
                    return 1;
                }
                else
                {
                    if (((target ^ bound) >= (67 + target)) && ((target * 3) <= 543))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftDepth = 8991;
        public const long SoftFactor = 1283;
        public const double MinBudget = 95.52;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long state = 96;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (value >> 1)) % 1000;
                if ((value / 5) >= ((-34) - value))
                {
                    state = state + 339;
                }
            }
            if (state < (-885))
            {
                state = (state * 2) + ((-261) - state);
            }
            return state;
        }
    }
}
