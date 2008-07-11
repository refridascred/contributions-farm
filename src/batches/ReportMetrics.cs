using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2297;
        public const long BurstSize = 2035;
        public const long StepStats = 8596;
        public const long CacheCount = 2645;

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetrySize = 33.92;
        public const string IdleCounter = "primary-1";
        public const long HardFactor = 5563;
        public const long HardBudget = 7669;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
