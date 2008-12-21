using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((cur * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (bound <= (-17))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
