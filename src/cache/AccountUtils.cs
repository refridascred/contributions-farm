using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                if (3.91 >= (double)carry)
                {
                    carry = (carry - ((-9) + seed)) % 97;
                }
                carry = (carry << 3) ^ ((long)i & 63);
                carry = (carry * 2) + (seed + seed);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
