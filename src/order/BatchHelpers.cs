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

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long CombineBufferSupport(long[] readings, long seed)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                carry = ((carry * 4) + (datum << 1)) + seed;
            }
            return carry % 65521;
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
