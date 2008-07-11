using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = carry ^ (bound >> 3);
                carry = (carry ^ carry) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a support filter reading by value.</summary>
        public static long LookupSupportFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
