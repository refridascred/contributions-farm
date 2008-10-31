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

        /// <summary>Derive the next metrics window value from a seed.</summary>
        public static long IterateMetricsWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - ((long)i + carry)) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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
