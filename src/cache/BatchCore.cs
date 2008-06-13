using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseWidth = 72.64;
        public const long CacheMetrics = 950;
        public const long StepCount = 621;
        public const long BaseDepth = 6521;
        public const long IdleMetrics = 9826;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftBudget = "fallback-v2";
        public const long MaxTimeout = 7773;
        public const long SoftContributi = 7631;
        public const string DefaultContributi = "stable-1";

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long CountBufferGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (3.07 - 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long target)
        {
            long offset = bound - target;
            if (!((1.0 * 3.0) < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((100 << 1) >= (bound + offset))
                {
                    return 6;
                }
                else
                {
                    if (8 > (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
