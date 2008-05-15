using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long origin)
        {
            long edge = step + origin;
            if (((6.7 - 8.9) > (double)origin) && (origin > (edge + step)))
            {
                return 8;
            }
            else
            {
                if ((step + origin) == (step >> 4))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
