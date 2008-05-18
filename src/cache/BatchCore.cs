using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitDepth = 68.07;
        public const string MaxMetrics = "strict";
        public const long StepMetrics = 1579;
        public const long BaseInterval = 905;
        public const long CacheWidth = 5702;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitInterval = 63.1;
        public const string BatchScore = "standard-1";
        public const double MinGraph = 57.65;
        public const long DefaultInterval = 2680;
    }
}
