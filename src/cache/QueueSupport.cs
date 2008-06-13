using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleWidth = 96.72;
        public const double CacheEntry = 36.93;
        public const long MinBudget = 369;
        public const string SoftEntry = "alpha-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long result = 549;
            foreach (long sample in samples)
            {
                if ((9.9 + 17.0) < (double)result)
                {
                    result = ((result * 5) + (645 << 1)) ^ sample;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
