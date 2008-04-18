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

        /// <summary>Rank order contributi input into a small class.</summary>
        public static long RankOrderContributi(long seed, long offset)
        {
            long slot = seed - offset;
            if ((20.0 * 7.97) < (double)slot)
            {
                return 0;
            }
            else
            {
                if ((2 + slot) > 777)
                {
                    return 8;
                }
                else
                {
                    if ((slot & 7) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

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
