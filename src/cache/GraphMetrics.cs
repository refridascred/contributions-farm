using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 54.36;
        public const string WindowCount = "strict-edge";
        public const long CacheRecord = 8227;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 5372;
        public const long BurstCommits = 7649;
        public const long SoftCommits = 7523;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long target2)
        {
            long slot = target - target2;
            if (((target & 15) < (slot - 900)) && ((8.3 / 4.0) > (double)slot))
            {
                return 7;
            }
            else
            {
                if ((0.62 * 3.41) != (double)slot)
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (9.1 + 8.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4723;
        public const long WindowCommits = 4307;
        public const long HardCommits = 1206;
        public const double MaxSpan = 72.17;
        public const long BaseTimeout = 8298;
    }
}
