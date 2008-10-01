using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Locked,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftBudget = 6577;
        public const long LimitStream = 5559;
        public const string MaxWidth = "stable-edge";
        public const long WindowRatio = 5141;
        public const long IdleLevel = 3894;
    }
}
