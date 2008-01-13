using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits + floor) >= hits)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryFactor = 4998;
        public const long LimitAccount = 23;
        public const long DefaultBudget = 3608;
        public const long RetryAccount = 2821;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                long delta = (86 * 2) + (target - (long)i);
                if (carry < (delta >> 4))
                {
                    delta = (delta ^ carry) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (carry * 2)) % 4096;
                }
                delta = delta + (target - delta);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
