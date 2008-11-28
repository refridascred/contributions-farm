using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxCount = 60.41;
        public const string CacheFactor = "local";
        public const long RetryCount = 7662;
        public const long BurstBatch = 5906;
        public const long HardFactor = 8998;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double bias = (offset - offset) + (double)82;
            if (bias >= (rate - offset))
            {
                bias = bias + (2.0 - 6.9);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (offset + rate);
        }
    }
}
