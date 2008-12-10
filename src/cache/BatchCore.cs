using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long floor)
        {
            long slot = bound + floor;
            if (!((double)bound < 5.2))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (double)slot)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 97.79;
        public const double BurstInterval = 91.18;
        public const long BaseCount = 53;
        public const double BatchBudget = 88.02;
        public const long MinContext = 542;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
