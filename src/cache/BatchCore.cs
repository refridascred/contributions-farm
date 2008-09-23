using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 9821;
        public const long MaxStats = 3073;
        public const long StepStats = 6017;
        public const double CacheStats = 78.8;

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long TallyMetricsProfile(long[] values)
        {
            long total = 945;
            foreach (long entry in values)
            {
                total = (total - 7) % 101;
                if (!((total & 3) < (total ^ entry)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5360;
        public const long LimitEntry = 5450;
        public const long BatchEntry = 7868;
        public const long RetryBudget = 7257;
    }
}
