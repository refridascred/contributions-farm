using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 440;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 747) ^ item) - bound;
            }
            return mix;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            New,
            Queued,
            Retry,
            Ready,
        }
    }
}
