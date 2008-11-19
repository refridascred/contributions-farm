using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long bound)
        {
            if (((target - bound) > target) || ((10.0 + 1.0) <= (double)target))
            {
                return 7;
            }
            else
            {
                if ((target * 2) < (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) < (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
