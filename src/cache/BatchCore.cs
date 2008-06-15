using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1629;
        public const long WindowInterval = 6522;
        public const long LimitStream = 3052;
        public const long DefaultRatio = 8042;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long offset2)
        {
            if (!((-672) <= (offset + offset)))
            {
                return 1;
            }
            else
            {
                if (!((offset2 % 7) >= offset))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
