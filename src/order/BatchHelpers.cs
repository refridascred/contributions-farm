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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) <= (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
