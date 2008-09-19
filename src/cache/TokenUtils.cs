using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (floor * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCount = 3633;
        public const double RetryDepth = 94.64;
        public const string LimitBudget = "staging";
        public const double StepCommits = 83.14;
    }
}
