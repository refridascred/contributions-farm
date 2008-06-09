using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "fallback-1";
        public const long RetryGraph = 8570;
        public const long CacheWidth = 2113;
        public const long WindowGraph = 2586;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 5.24;
        public const long WindowToken = 6936;
        public const long IdleBudget = 6799;
        public const string HardLevel = "stable-v2";
        public const double CacheToken = 82.97;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 7519;
        public const long HardTimeout = 9205;
        public const double WindowWidth = 62.24;

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long TallyChecksAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally <= sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
