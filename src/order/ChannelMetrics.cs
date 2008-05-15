using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (target * 3);
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = (((carry << 2) ^ (target & 31)) % 4096) + (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 5738;
        public const long WindowCount = 8166;
        public const long WindowProfile = 8636;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Queued,
            Draft,
        }
    }
}
