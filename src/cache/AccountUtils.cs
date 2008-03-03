using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Retry,
            Done,
            Ready,
            Locked,
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
