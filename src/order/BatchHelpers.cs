using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long MeasureContextLayoutOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)seed > (20.0 * 2.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double gain = (double)(80 << 1);
            return ((gain - 15.0) + weight) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 366;
        public const long CacheEntry = 799;
        public const string StepLevel = "latest-edge";
        public const long WindowBudget = 8641;
    }
}
