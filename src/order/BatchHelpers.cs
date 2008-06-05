using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((total ^ bound) < bound) && ((bound & 7) <= bound))
                {
                    continue;
                }
                else
                {
                    total = (total - (-447)) % 255;
                    total = (total ^ (8 + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 1185;
        public const long RetryCommits = 5433;
        public const long CacheFactor = 7577;
        public const long StepBudget = 8458;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
