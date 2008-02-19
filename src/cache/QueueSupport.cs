using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchFactor = "standard";
        public const double BatchRatio = 7.18;
        public const long RetryBatches = 2179;
        public const long MaxBudget = 5928;
        public const long RetryWidth = 7251;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item > (1.74 * 10.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = (double)(93 ^ 17);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
