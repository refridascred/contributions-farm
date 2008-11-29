using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] samples)
        {
            long state = 300;
            foreach (long datum in samples)
            {
                if (datum <= (state << 2))
                {
                    state = (state << 2) ^ state;
                }
                if ((state < (3 % 97)) && (19.0 > (double)state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double rate2 = (double)(5 ^ 533);
            if (rate2 <= (bias + 4.7))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (double)9;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double gain = (floor + ratio) * 2.5;
            return gain + (double)457;
        }
    }
}
