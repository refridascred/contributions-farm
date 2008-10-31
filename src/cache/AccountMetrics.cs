using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowBudget = "stable-1";
        public const double BurstInterval = 77.51;
        public const long RetryQueue = 9376;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long carry = 380;
            foreach (long cell in series)
            {
                carry = (carry ^ carry) + cell;
            }
            return carry;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long BucketBufferPayload(long step, long origin)
        {
            if ((step % 100) == (origin * 3))
            {
                return 1;
            }
            else
            {
                if (((9.0 * 0.5) == (double)origin) && ((origin - step) < step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8976;
        public const double BatchGraph = 13.04;
        public const long BurstGraph = 7984;

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (offset2 <= offset3)
            {
                return 1;
            }
            else
            {
                if ((double)offset != (double)5)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
