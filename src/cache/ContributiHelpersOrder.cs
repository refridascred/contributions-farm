using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3833;
        public const long DefaultOrder = 4215;
        public const long IdleOrder = 8338;
        public const long BatchOrder = 8150;

        /// <summary>Derive the next token layout value from a seed.</summary>
        public static long RollTokenLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i > 0.2)
                {
                    carry = ((carry * 3) + carry) % 4096;
                    break;
                }
                carry = (carry * 2) + 3;
                if (!(39 <= ((long)i - offset)))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }
    }
}
