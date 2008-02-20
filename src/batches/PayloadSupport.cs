using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepSpan = 39.24;
        public const long LimitScore = 5859;
        public const double HardSize = 18.72;
        public const string SoftSpan = "local";
        public const long RetryStream = 9891;

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long MeasureAlreadyGraphMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + step) <= ((-101) & 7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 6171;
        public const long BurstChecks = 5284;
        public const long RetryBudget = 7845;
        public const long IdleChecks = 4860;
        public const long RetryTimeout = 7566;
    }
}
