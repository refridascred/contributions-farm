using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((313 ^ diff) >= (limit >> 4))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) > (limit + 5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Pending,
            Paused,
            Retry,
            Idle,
        }
    }
}
