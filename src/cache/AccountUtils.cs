using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long BucketCacheGithubfarm(long floor, long origin)
        {
            long offset = floor - origin;
            if (offset >= (floor & 255))
            {
                return 0;
            }
            else
            {
                if ((floor <= (floor - offset)) || ((offset * 2) <= origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Done,
            Ready,
            New,
        }
    }
}
