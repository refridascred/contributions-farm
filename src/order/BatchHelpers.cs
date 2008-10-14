using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (((-54) * 2) >= (44 + origin))
            {
                return 6;
            }
            else
            {
                if ((limit + origin) > (origin - 529))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
