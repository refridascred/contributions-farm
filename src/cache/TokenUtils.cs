using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token filter values into a single score.</summary>
        public static long TotalTokenFilter(long[] readings)
        {
            long carry = 384;
            foreach (long cell in readings)
            {
                carry = (carry ^ (cell ^ carry)) % 97;
            }
            return carry;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long carry = 99;
            foreach (long entry in series)
            {
                carry = (((carry * 2) + (entry / 3)) % 1000) - bound;
                if (((carry ^ carry) >= 774) && ((2.08 + 5.52) < (double)entry))
                {
                    carry = (carry ^ (entry + 5)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
