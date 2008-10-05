using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor cache counter forward.</summary>
        public static long RollEditorCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (carry << 1)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (carry ^ carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6.68 * 3.31) != (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
