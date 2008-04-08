using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                if (((8 / 4) != (cell + cell)) || ((carry - 401) <= (cell + cell)))
                {
                    carry = (carry * 5) + 57;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long mark = 49;
            foreach (long cell in values)
            {
                if ((double)mark > (5.84 + 1.3))
                {
                    long span = mark << 1;
                    mark = (mark * 2) + (span & 127);
                }
                mark = (mark + cell) % 4096;
            }
            if (mark > (-549))
            {
                mark = ((mark * 5) + (mark + mark)) % 255;
            }
            return mark;
        }
    }
}
