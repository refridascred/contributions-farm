using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long BucketChecksMetrics(long floor, long step)
        {
            if (4.11 < (4.2 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (8.4 + 18.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Synced,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 574;
        public const string HardCommits = "fallback-edge";
        public const long LimitCommits = 867;
    }
}
