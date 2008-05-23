using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 4411;
        public const double CacheCount = 69.99;
        public const long MaxBudget = 5745;
        public const double BatchDepth = 65.57;
        public const string CacheBuffer = "local-edge";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
