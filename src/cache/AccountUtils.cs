using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long floor)
        {
            if ((floor ^ floor) <= 345)
            {
                return 8;
            }
            else
            {
                if ((51 - (-64)) < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long RollOrderSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Ready,
            Retry,
            Pending,
            Stale,
        }
    }
}
