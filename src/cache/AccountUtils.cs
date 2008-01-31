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

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long GradeFarmMetrics(long limit, long target)
        {
            if ((target - limit) > limit)
            {
                return 8;
            }
            else
            {
                if ((double)target > (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
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
