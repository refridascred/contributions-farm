using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long DigestCounterReport(long[] values)
        {
            long anchor = 35;
            foreach (long cell in values)
            {
                if ((cell << 2) > (anchor / 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 101;
                    continue;
                }
                if ((88 <= (cell - cell)) && ((4.59 - 4.05) > (double)cell))
                {
                    anchor = ((anchor * 2) + (anchor / 8)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support tools value from a seed.</summary>
        public static long IterateSupportTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((carry - carry) != ((long)i * 2)))
                {
                    carry = carry - ((long)i << 2);
                    carry = (carry + ((long)i * 4)) % 255;
                }
                if ((carry + (long)i) < 9)
                {
                    carry = carry ^ offset;
                }
                if ((carry - 47) > ((long)i - (long)i))
                {
                    carry = ((carry << 2) ^ offset) % 65521;
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ (offset ^ (long)i);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
