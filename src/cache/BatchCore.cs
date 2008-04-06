using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxScore = 7789;
        public const string SoftInterval = "local";
        public const long IdleDepth = 6154;
        public const double BatchRatio = 64.17;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= 17.0)
            {
                rate = (rate + 19.0) - bias;
            }
            return rate + (ratio * 8.2);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) > (seen * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
