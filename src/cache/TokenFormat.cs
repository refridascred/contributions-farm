using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 516;
            foreach (long item in values)
            {
                sum = sum - (item >> 2);
                sum = (sum + (sum % 64)) % 101;
            }
            if (sum < (-763))
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph account value.</summary>
        public static double BlendGraphAccount(double scale, double span)
        {
            double gain = scale;
            if (gain > (scale + span))
            {
                gain = gain - 11.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)32) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }
    }
}
