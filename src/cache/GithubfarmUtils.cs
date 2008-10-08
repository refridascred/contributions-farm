using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Failed,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)4 >= (double)offset)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
