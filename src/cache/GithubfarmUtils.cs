using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long seed)
        {
            if (origin <= (948 + 224))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 8.17) && ((seed / 7) > 4))
                {
                    return 0;
                }
                else
                {
                    if (origin >= (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 7002;
        public const long MinDepth = 1529;
        public const long SoftWidth = 2296;
    }
}
