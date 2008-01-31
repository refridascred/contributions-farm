using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long target)
        {
            if (floor <= (floor + 61))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor << 2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.54 / 5.0) > (double)count)
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }
    }
}
