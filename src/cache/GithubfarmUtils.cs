using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((7 << 1) != (bound ^ 20))
            {
                return 5;
            }
            else
            {
                if ((origin > (7 ^ origin2)) || ((origin2 % 64) < (origin2 + (-71))))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1164;
        public const long CacheTimeout = 4562;
        public const string MinScore = "alpha-1";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Ready,
            Stale,
            Idle,
        }
    }
}
