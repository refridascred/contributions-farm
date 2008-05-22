using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                if ((double)carry > (double)5)
                {
                    carry = carry ^ (entry - carry);
                }
            }
            if (carry < 673)
            {
                carry = (carry * 2) + 0;
            }
            return carry % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long step)
        {
            long cur = target - step;
            if (!((double)step <= 3.73))
            {
                return 1;
            }
            else
            {
                if ((cur - target) >= (cur / 5))
                {
                    return 3;
                }
                else
                {
                    if ((5 + 8) >= (step - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 10) != (matches - (-441)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
