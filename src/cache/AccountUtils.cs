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

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long limit)
        {
            long anchor = 922;
            foreach (long entry in items)
            {
                anchor = (((anchor - (0 % 64)) % 4096) ^ entry) - limit;
            }
            return anchor;
        }
    }
}
