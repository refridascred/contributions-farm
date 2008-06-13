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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long bound, long offset)
        {
            if ((double)offset >= (7.46 - 8.09))
            {
                return 3;
            }
            else
            {
                if (bound <= (bound & 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset > (offset ^ bound)) || ((6.0 + 3.71) < (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 63) != (offset - 55))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
