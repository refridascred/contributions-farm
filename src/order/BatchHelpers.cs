using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long FindSupportCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long carry = 113;
            foreach (long value in items)
            {
                if ((938 + value) <= (carry - value))
                {
                    carry = carry ^ (value - carry);
                }
            }
            if (carry > 9)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double span)
        {
            double rate2 = rate * 20.0;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate - span);
        }
    }
}
