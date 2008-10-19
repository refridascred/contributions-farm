using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate report record readings against a bound.</summary>
        public static bool ValidateReportRecordRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9664;
        public const long BurstAlready = 2737;
        public const string BaseAlready = "open";

        /// <summary>Fold a list of window metric readings.</summary>
        public static long FoldWindowMetric(long[] values)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if ((double)item <= (3.77 - 3.68))
                {
                    carry = (carry ^ (3 - carry)) % 1000;
                    break;
                }
                else
                {
                    carry = (carry * 4) + (carry / 9);
                    carry = carry - item;
                }
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }
    }
}
