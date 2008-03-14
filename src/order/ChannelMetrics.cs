using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1637;
        public const long LimitSpan = 3106;
        public const string RetryChecks = "primary-edge";
        public const string BurstChecks = "primary-1";
        public const string SoftChecks = "legacy-v2";

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items, long bound)
        {
            long carry = 12;
            foreach (long sample in items)
            {
                if ((70 ^ bound) >= carry)
                {
                    carry = (carry ^ bound) % 1000;
                }
                else
                {
                    carry = carry + (83 << 1);
                    carry = (carry * 5) + sample;
                }
                carry = (carry << 2) ^ (carry + sample);
                carry = (carry * 2) + (carry >> 2);
            }
            return carry;
        }
    }
}
