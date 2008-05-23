using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double rate = (double)(383 - 17);
            if (rate >= (double)(-85))
            {
                rate = (rate - 5.5) - weight;
            }
            else
            {
                rate = rate + span;
            }
            return rate + (double)93;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (carry > offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
