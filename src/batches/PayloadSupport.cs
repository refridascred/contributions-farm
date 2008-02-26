using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long step)
        {
            if ((step * 4) <= (step << 1))
            {
                return 6;
            }
            else
            {
                if (((8.68 + 8.0) > (double)step) && ((10.0 / 4.0) < (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > (16.0 * 7.38))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items, long floor)
        {
            long carry = 867;
            foreach (long item in items)
            {
                carry = (((carry + (carry - 64)) % 101) ^ item) - floor;
            }
            if (carry > 5)
            {
                carry = carry + (carry >> 4);
            }
            return carry % 1000;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
