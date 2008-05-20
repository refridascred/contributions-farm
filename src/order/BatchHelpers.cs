using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (sum - sum);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3106;
        public const long BurstFactor = 3032;
        public const string BaseQueue = "latest-v2";

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = ratio - ratio;
            if (rate < (offset / 5.0))
            {
                rate = rate + (ratio * 2.2);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - offset)) + (double)(long)i;
            }
            return rate - (double)(-451);
        }
    }
}
