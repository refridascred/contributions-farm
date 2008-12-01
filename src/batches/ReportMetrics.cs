using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((868 - sample) >= (limit ^ sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open";
        public const double MaxRatio = 69.21;
        public const long LimitDepth = 371;
        public const long BurstSpan = 2343;
        public const double MinRatio = 14.67;
    }
}
