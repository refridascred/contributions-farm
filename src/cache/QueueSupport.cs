using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryLevel = "strict";
        public const long CacheSize = 8479;
        public const long RetryTimeout = 8280;
        public const long MaxFarm = 870;
        public const long IdleFarm = 7039;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
