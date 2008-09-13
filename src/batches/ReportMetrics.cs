using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7503;
        public const long IdleSession = 4546;
        public const string CacheSession = "stable-v2";

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 342;
            foreach (long entry in readings)
            {
                carry = (carry ^ (carry % 60)) ^ entry;
                carry = carry - (22 << 1);
            }
            if (carry > 558)
            {
                carry = carry - (bound + 3);
            }
            return carry;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long limit)
        {
            if ((1 + target) <= (limit << 1))
            {
                return 6;
            }
            else
            {
                if ((double)target > (9.0 * 19.0))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
