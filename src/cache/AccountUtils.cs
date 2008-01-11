using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a payload stream value against two limits.</summary>
        public static long ClassifyPayloadStream(long offset, long limit)
        {
            if ((offset ^ offset) != (limit << 1))
            {
                return 0;
            }
            else
            {
                if (332 >= (limit + offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
