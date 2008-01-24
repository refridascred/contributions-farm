using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Ready,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long limit)
        {
            if ((150 ^ 97) > (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((755 - target) <= target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Closed,
            Synced,
            Active,
        }
    }
}
