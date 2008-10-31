using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 50.1;
        public const long BaseBudget = 1153;
        public const string HardScore = "strict-edge";
        public const long WindowCount = 2815;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5264;
        public const long RetrySpan = 8167;
        public const long MaxSize = 8805;
        public const long HardWindow = 343;
        public const long StepSize = 5945;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9410;
        public const long BurstWindow = 296;
        public const double CacheWindow = 4.08;
        public const string LimitTimeout = "primary-edge";
        public const string BurstBudget = "latest-1";
    }
}
