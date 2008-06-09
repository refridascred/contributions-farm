using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowTimeout = 46;
        public const string CacheBudget = "standard-1";
        public const string DefaultFormat = "local-v2";
        public const double BurstFormat = 48.81;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 727;
        public const string HardSpan = "strict-edge";
        public const double BaseGithubfarm = 71.18;
        public const double MinWidth = 22.87;
        public const long SoftInterval = 4074;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 4618;
        public const long StepLayout = 3082;
        public const long CacheRatio = 1397;
        public const string LimitLayout = "local-v2";
        public const string IdleWidth = "fallback-1";
    }
}
