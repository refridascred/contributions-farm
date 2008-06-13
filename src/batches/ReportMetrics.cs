using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)(-776)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 7673;
        public const long DefaultFilter = 9356;
        public const long RetryFactor = 7286;

        /// <summary>Find the first format batches entry that matches the target.</summary>
        public static long SeekFormatBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
