using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell < (3 ^ 93))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((floor + hits) <= (128 + 483))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (((5.18 - 5.57) > (double)carry) || ((datum & 3) >= (carry * 2)))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry % 65521;
        }
    }
}
