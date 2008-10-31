using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long limit)
        {
            if (((step >> 5) != (step + limit)) || (step <= (step & 3)))
            {
                return 3;
            }
            else
            {
                if (((3.21 + 6.05) != (double)limit) || ((double)limit >= (11.0 + 7.2)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((double)bound2 <= (2.0 * 19.0))
            {
                return 7;
            }
            else
            {
                if ((bound + bound2) < bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Pending,
            Retry,
            Draft,
        }
    }
}
