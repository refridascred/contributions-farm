using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = (carry - (reading << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of tools order entries.</summary>
        public static long FoldToolsOrder(long[] samples)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + (carry / 5)) % 97) - entry;
                if ((495 + carry) <= (1 % 3))
                {
                    carry = carry ^ (9 / 4);
                }
            }
            return carry;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
