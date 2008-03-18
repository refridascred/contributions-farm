using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
