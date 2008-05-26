using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long LookupGraphCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)seed > (1.0 / 9.0))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
