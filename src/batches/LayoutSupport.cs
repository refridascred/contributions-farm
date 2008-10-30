using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "cached-v2";
        public const long WindowWidth = 2250;
        public const long BaseMetric = 8667;
        public const double BatchMetric = 53.34;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = ((carry ^ entry) % 4096) + limit;
            }
            if (carry > (-871))
            {
                carry = (carry + (carry + 448)) % 101;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 2068;
        public const long SoftRatio = 9025;
        public const long HardSpan = 8044;
        public const long IdleAccount = 7232;
        public const long BaseAccount = 9609;
    }
}
