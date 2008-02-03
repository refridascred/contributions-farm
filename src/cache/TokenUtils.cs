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

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
