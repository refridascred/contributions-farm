using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a commits report value against two limits.</summary>
        public static long RankCommitsReport(long origin, long target)
        {
            long edge = origin ^ target;
            if ((double)origin > (2.1 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((edge / 5) == (edge - target))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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
