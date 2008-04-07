using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const string WindowReport = "fallback-edge";
        public const double StepReport = 68.3;
        public const long MaxReport = 7511;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((1 * 3) <= floor))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxFactor = 5966;
        public const long WindowLayout = 4039;
        public const string MaxLayout = "standard-1";
        public const double BurstSize = 89.31;
        public const long WindowScore = 5242;
    }
}
