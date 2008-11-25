using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 5561;
        public const string BatchSchema = "standard";
        public const string CacheFactor = "stable-1";
        public const long RetryDepth = 3164;
        public const string BurstSchema = "fallback-1";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long floor, long step)
        {
            long span = floor + step;
            if ((floor * 2) <= (floor - step))
            {
                return 7;
            }
            else
            {
                if ((5.7 + 11.0) != (double)span)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
