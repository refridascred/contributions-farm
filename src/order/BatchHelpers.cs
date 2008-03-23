using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long floor)
        {
            long carry = 897;
            foreach (long value in levels)
            {
                if ((double)floor >= (double)value)
                {
                    carry = carry - (855 - value);
                }
            }
            if (carry < 10)
            {
                carry = (carry - floor) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
