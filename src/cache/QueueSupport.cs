using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const long DefaultFactor = 7196;
        public const long MaxFarm = 6134;
        public const long RetryFarm = 4349;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double scale = bias;
            if (scale > (double)(-98))
            {
                scale = (scale + (scale * 1.0)) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 6.0) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Find the first batch contributi entry that matches the target.</summary>
        public static long FindBatchContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
