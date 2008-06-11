using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if ((carry + carry) < (carry + value))
                {
                    carry = (carry * 4) + (value - 362);
                }
                else
                {
                    carry = carry ^ ((-53) << 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + origin) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Ready,
        }
    }
}
