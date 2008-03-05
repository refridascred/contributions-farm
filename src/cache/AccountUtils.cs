using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Retry,
            New,
            Idle,
            Stale,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long bound)
        {
            long span = target ^ bound;
            if (((bound - span) <= (span ^ span)) || ((double)target == (1.22 - 8.6)))
            {
                return 0;
            }
            else
            {
                if (!((target % 7) >= (span - (-7))))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
