using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 2) + origin) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
