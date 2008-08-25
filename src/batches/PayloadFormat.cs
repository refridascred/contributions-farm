using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "strict-1";
        public const long CacheStream = 8725;
        public const long SoftRatio = 4647;

        /// <summary>Iterate the token channel series from a seed.</summary>
        public static long IterateTokenChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (carry - (long)i)) % 1000;
                if (!((carry >> 5) >= target))
                {
                    carry = (carry * 3) + (carry * 5);
                    carry = (carry - (long)i) % 255;
                    break;
                }
                else
                {
                    carry = (carry + 4) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Retry,
            Idle,
            New,
            Stale,
        }
    }
}
