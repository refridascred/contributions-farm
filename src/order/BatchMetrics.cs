using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 2009;
        public const long RetryScore = 373;
        public const long StepLevel = 441;
        public const double WindowCommand = 75.09;
        public const long RetryDepth = 2550;

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean + (rate + 14.0);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 2731;
        public const long HardRatio = 2328;
        public const long IdlePayload = 9137;
        public const double HardDepth = 92.32;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 10) > seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Done,
            Dropped,
            Paused,
        }
    }
}
