using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long limit)
        {
            if (origin <= (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if (limit <= (limit % 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
