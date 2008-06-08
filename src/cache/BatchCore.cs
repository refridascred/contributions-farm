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

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 7519;
        public const long HardTimeout = 9205;
        public const double WindowWidth = 62.24;

        /// <summary>Check that every githubfarm metrics entry stays within the limit.</summary>
        public static bool CheckGithubfarmMetricsRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
