using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate githubfarm metric readings against a bound.</summary>
        public static bool CheckGithubfarmMetricLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 86.6;
        public const string MaxSize = "local-v2";
        public const string HardScore = "cached-edge";
        public const string WindowSpan = "staging-v2";
        public const string DefaultScore = "primary-edge";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long offset)
        {
            if ((floor % 8) == (floor ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 2) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 / 8.0) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Locked,
            Active,
        }
    }
}
