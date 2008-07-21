using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items, long target)
        {
            long sum = 429;
            foreach (long cell in items)
            {
                sum = ((sum - (-48)) % 101) + cell;
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (target << 1)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length <= 6.03)
                {
                    count = ((count + 1) + item) + target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data)
        {
            long anchor = 773;
            foreach (long reading in data)
            {
                if ((5 - reading) != (reading - anchor))
                {
                    anchor = ((anchor * 3) + (reading + reading)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (-122)) % 255;
                }
            }
            if (anchor > 731)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
