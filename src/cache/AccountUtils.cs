using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 73.36;
        public const long MaxCommits = 9286;
        public const long LimitCommits = 2097;
        public const long BatchCommits = 6613;
        public const double LimitDepth = 62.28;

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool GuardCounterCacheBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
