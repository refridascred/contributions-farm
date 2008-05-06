using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long limit)
        {
            long state = 533;
            foreach (long entry in levels)
            {
                if (limit <= (limit / 8))
                {
                    state = ((state * 2) + (659 << 3)) - entry;
                }
            }
            return state % 97;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
