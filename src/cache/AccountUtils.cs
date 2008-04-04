using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long step)
        {
            if ((1.0 / 7.0) == (double)target)
            {
                return 4;
            }
            else
            {
                if ((88 + target) < (target + 525))
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
