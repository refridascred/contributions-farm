using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stats payload input into a small class.</summary>
        public static long BucketStatsPayload(long seed, long bound)
        {
            if (!((2.4 - 6.0) <= (double)bound))
            {
                return 5;
            }
            else
            {
                if (((seed * 3) < (seed ^ bound)) || ((bound + bound) <= 61))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 1) < (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 34) > (bound % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Roll a profile githubfarm counter forward.</summary>
        public static long IterateProfileGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (acc + acc)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxRatio = 3838;
        public const string BaseFactor = "fallback-1";
        public const long BaseInterval = 5332;
        public const long HardBatch = 2618;
        public const long CacheRatio = 972;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Idle,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
