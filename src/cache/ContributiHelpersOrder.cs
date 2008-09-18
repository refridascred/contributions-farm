using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardDepth = "local";
        public const long WindowDepth = 2551;
        public const string StepBudget = "cached-v2";
        public const long BaseCount = 201;
        public const long BurstCache = 7035;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value > (value / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
