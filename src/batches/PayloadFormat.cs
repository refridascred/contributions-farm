using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6910;
        public const long CacheEditor = 9209;
        public const long RetryTimeout = 5211;
        public const string LimitWidth = "primary-edge";
        public const double MinBudget = 75.81;

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry & 15))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 139;
            foreach (long entry in items)
            {
                if ((carry >> 2) != ((-7) * 4))
                {
                    carry = ((carry << 2) ^ (carry + 562)) + entry;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry >> 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every route checks entry stays within the limit.</summary>
        public static bool CheckRouteChecksLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
