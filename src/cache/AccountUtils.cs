using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 3108;
        public const double LimitMetrics = 55.6;
        public const long StepMetrics = 6109;
        public const long IdleMetrics = 5904;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long SortToolsEntry(long floor, long offset)
        {
            long diff = floor - offset;
            if (6 <= (18 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset * 5) < offset)
                {
                    return 0;
                }
                else
                {
                    if (diff < floor)
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
    }
}
