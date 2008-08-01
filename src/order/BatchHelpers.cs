using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long mark = 495;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (99 ^ 69)) % 101) + cell;
                mark = mark + (-67);
            }
            return mark % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 225;
            foreach (long value in samples)
            {
                if (value < (result << 1))
                {
                    result = (result + (value - result)) % 4096;
                }
                else
                {
                    result = (result + (value - result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            if ((target << 1) > 75)
            {
                return 3;
            }
            else
            {
                if (!((target * 2) <= (target << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
