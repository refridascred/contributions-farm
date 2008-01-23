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

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long limit)
        {
            long carry = 330;
            foreach (long value in samples)
            {
                carry = ((carry - limit) % 255) + value;
                carry = ((carry << 2) ^ (limit / 4)) % 1000;
            }
            if (carry > 15)
            {
                carry = carry + carry;
            }
            return carry;
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
