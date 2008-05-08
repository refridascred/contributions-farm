using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long HardEntry = 5331;
        public const long StepEntry = 2389;

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 6.12;
        public const long StepInterval = 2923;
        public const long BatchFormat = 3238;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
