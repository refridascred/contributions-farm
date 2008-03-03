using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank already batch input into a small class.</summary>
        public static long BucketAlreadyBatch(long limit, long step)
        {
            if ((6.0 + 16.0) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((9 >= limit) || ((8.3 / 5.0) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long origin)
        {
            long diff = step - origin;
            if ((diff > 818) && ((double)step <= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((3.27 * 2.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
