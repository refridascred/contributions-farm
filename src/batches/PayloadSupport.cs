using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry * 3) + offset) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
