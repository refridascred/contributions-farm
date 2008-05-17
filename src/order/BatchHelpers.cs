using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = (sum - sum) % 255;
                if (sum <= ((-375) ^ datum))
                {
                    sum = ((sum << 3) ^ (4 + datum)) % 101;
                }
            }
            if (sum > 151)
            {
                sum = (sum ^ (sum % 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of batch counter entries.</summary>
        public static long FoldBatchCounter(long[] series, long origin)
        {
            long carry = 501;
            foreach (long value in series)
            {
                if (carry >= value)
                {
                    carry = (carry ^ (origin & 15)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (count * 2))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
