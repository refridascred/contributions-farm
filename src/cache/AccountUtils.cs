using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Paused,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if ((double)offset > (8.1 / 8.0))
            {
                return 2;
            }
            else
            {
                if ((6.0 + 3.9) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            New,
            Dropped,
            Ready,
            Synced,
        }
    }
}
