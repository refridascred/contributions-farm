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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
