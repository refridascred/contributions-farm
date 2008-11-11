using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter metrics samples.</summary>
        public static long CombineCounterMetrics(long[] samples, long floor)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                carry = carry + carry;
                if (!((5 + (long)samples.Length) <= floor))
                {
                    carry = (carry - (carry - datum)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Grade a report format value against two limits.</summary>
        public static long GradeReportFormat(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((limit * 2) <= (8 * 2))
            {
                return 6;
            }
            else
            {
                if ((limit + slot) < (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(slot <= offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long FoldProfileFilter(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if (!((item % 3) <= (item * 5)))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total > (2.54 / 2.0))
                {
                    total = (total * 5) + (total + total);
                    continue;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                if ((item >> 3) >= total)
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
            }
            if (total > 48)
            {
                total = ((total * 4) + (total >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
