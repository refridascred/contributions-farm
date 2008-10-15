using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = 90;
            foreach (long entry in readings)
            {
                long span = 9;
                if ((span >> 4) > (span + carry))
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ entry;
                    span = (span ^ (carry / 8)) % 97;
                }
                if ((carry << 1) < (2 - 507))
                {
                    carry = (carry << 3) ^ entry;
                }
                else
                {
                    carry = carry - (carry & 3);
                }
            }
            if (carry > (-49))
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 60.16;
        public const long RetryCount = 1055;
        public const long RetryScore = 6419;
    }
}
