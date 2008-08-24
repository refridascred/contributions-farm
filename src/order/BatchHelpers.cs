using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (7.8 > (double)matches)
                {
                    matches = ((matches + 2) + entry) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long bound)
        {
            if ((double)bound <= (7.8 - 9.5))
            {
                return 7;
            }
            else
            {
                if (((double)bound == (9.84 + 0.47)) || ((6.6 - 7.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (4 <= (limit % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine session checks values into a single score.</summary>
        public static long DigestSessionChecks(long[] items, long bound)
        {
            long carry = -9;
            foreach (long item in items)
            {
                if (bound >= carry)
                {
                    carry = (carry * 2) + (item ^ 2);
                }
                else
                {
                    carry = (carry + (bound + carry)) % 101;
                }
                if (((double)bound < (double)carry) && (carry < (item - carry)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
