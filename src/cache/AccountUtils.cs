using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - sample) < (sample << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics stream entry stays within the limit.</summary>
        public static bool GuardMetricsStreamBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
