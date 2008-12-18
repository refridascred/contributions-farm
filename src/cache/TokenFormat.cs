using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload report samples.</summary>
        public static long TallyPayloadReport(long[] samples, long target)
        {
            long carry = -772;
            foreach (long value in samples)
            {
                if ((carry + value) <= (target + carry))
                {
                    carry = carry - (2 + 458);
                    carry = (carry ^ (value + target)) % 101;
                }
                carry = carry - carry;
                carry = (carry << 2) ^ (target / 9);
                if ((carry % 97) <= target)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - 496) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
