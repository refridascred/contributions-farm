using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first command stream entry that matches the target.</summary>
        public static long LookupCommandStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long total = 261;
            foreach (long datum in samples)
            {
                if (!((datum + 359) <= total))
                {
                    total = total + total;
                }
                total = ((total * 2) + (617 % 24)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 3) ^ ((long)i + bound);
                if ((bound + carry) <= ((long)i * 4))
                {
                    carry = (carry * 3) + (carry + bound);
                    carry = carry - (carry - carry);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
