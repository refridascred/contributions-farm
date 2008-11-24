using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Pending,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            if ((offset << 1) >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
