using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data, long offset)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry + (offset + offset)) % 101) - entry;
            }
            return carry;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 44;
            foreach (long reading in values)
            {
                if (!((double)reading < 1.83))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 442)
            {
                acc = acc + (acc % 2);
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
