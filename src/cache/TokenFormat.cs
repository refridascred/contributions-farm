using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 333;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (item << 2);
            }
            return sum % 1000;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches report value.</summary>
        public static double SmoothBatchesReport(double weight, double offset)
        {
            double mean = (double)(713 * 2);
            if (mean >= offset)
            {
                mean = (mean - (mean / 5.0)) + weight;
            }
            return mean - offset;
        }
    }
}
