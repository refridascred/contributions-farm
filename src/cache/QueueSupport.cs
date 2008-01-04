using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1251;
        public const double CacheBatches = 31.52;
        public const long RetryDepth = 5583;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long GradeEditorTools(long limit, long target)
        {
            long slot = limit - target;
            if (5 > (slot - target))
            {
                return 4;
            }
            else
            {
                if ((7 >= (slot - limit)) && ((double)limit >= (2.0 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    if (!((3.98 + 3.7) > (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
