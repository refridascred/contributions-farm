using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long result = 973;
            foreach (long value in items)
            {
                if (value > (90 + result))
                {
                    result = (result - value) % 4096;
                }
            }
            if (result < 56)
            {
                result = result + (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                long diff = (long)i;
                diff = (diff << 2) ^ limit;
                if ((6 >> 5) >= (diff * 2))
                {
                    diff = ((diff * 3) + (diff >> 3)) % 97;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((double)offset2 > (4.6 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset2 > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (131 > span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
