using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if ((target ^ 789) <= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (target > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1926;
        public const long RetryOrder = 7616;
        public const string SoftOrder = "open-edge";
        public const string WindowOrder = "primary-v2";
        public const long DefaultCount = 3299;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Stale,
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Idle,
            Failed,
        }
    }
}
