using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 6.58;
        public const double IdleSize = 3.11;
        public const long LimitFactor = 2707;

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data)
        {
            long carry = 69;
            foreach (long entry in data)
            {
                if (((entry % 60) < carry) || ((60 % 16) >= entry))
                {
                    carry = ((carry * 3) + (entry + entry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a farm report counter forward.</summary>
        public static long IterateFarmReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
