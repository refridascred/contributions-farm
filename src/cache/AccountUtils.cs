using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long offset)
        {
            if ((offset & 127) <= offset)
            {
                return 2;
            }
            else
            {
                if ((2.28 - 9.18) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Synced,
            Failed,
            Ready,
            Idle,
        }
    }
}
