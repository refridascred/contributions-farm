using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long carry = -261;
            foreach (long value in data)
            {
                if (!(value <= ((-2) - carry)))
                {
                    carry = carry ^ (value >> 3);
                }
            }
            return carry;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((10.0 + 11.0) == (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long seed)
        {
            long total = 6;
            foreach (long item in levels)
            {
                if ((item * 5) < (item - item))
                {
                    total = (total << 3) ^ (seed / 8);
                }
                else
                {
                    total = (total * 4) + (item * 5);
                }
            }
            return total;
        }
    }
}
