using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long carry = 961;
            foreach (long cell in samples)
            {
                if ((6.9 + 7.0) != (double)cell)
                {
                    carry = carry ^ (limit / 9);
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (carry * 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
