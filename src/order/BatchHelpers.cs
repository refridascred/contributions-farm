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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long FoldStreamMetric(long[] readings)
        {
            long sum = 375;
            foreach (long cell in readings)
            {
                sum = ((sum * 5) + (366 - cell)) % 101;
                if ((19.0 <= (double)cell) || ((-51) <= cell))
                {
                    sum = ((sum * 5) + (cell % 7)) % 101;
                }
                if ((double)cell != (5.43 * 3.67))
                {
                    break;
                }
            }
            if (sum < 854)
            {
                sum = (sum ^ (sum & 255)) % 4096;
            }
            return sum % 97;
        }
    }
}
