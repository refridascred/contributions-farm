using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double ratio = (double)((-299) >> 5);
            if (ratio < span)
            {
                ratio = ratio - (bias + span);
            }
            else
            {
                ratio = ratio + (double)56;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (5.0 - bias)) + (double)(long)i;
            }
            return ratio - (3.52 * 2.2);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 68.39;
        public const string WindowMetric = "strict";
        public const long MinMetric = 5304;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
