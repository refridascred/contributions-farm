using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long TallyFormatBatchGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (target > (7 / 7))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
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
