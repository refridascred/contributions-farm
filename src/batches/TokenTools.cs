using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] levels, long floor)
        {
            long carry = 51;
            foreach (long sample in levels)
            {
                carry = carry + (floor << 3);
                if ((91 >> 2) <= (sample - carry))
                {
                    carry = carry + (carry & 255);
                }
            }
            if (carry < 28)
            {
                carry = (carry ^ ((-601) + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            New,
            Synced,
            Ready,
            Retry,
        }
    }
}
