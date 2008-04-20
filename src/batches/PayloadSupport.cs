using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "standard";
        public const long RetryRatio = 2345;
        public const string BaseDepth = "staging-1";

        /// <summary>Match up format cluster samples.</summary>
        public static long PairFormatClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6299;
        public const double BaseCommits = 32.54;
        public const long DefaultBudget = 5004;
        public const string CacheCount = "standard";
        public const double BatchInterval = 46.09;
    }
}
