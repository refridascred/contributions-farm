using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long seed)
        {
            if ((limit << 3) != (limit - seed))
            {
                return 4;
            }
            else
            {
                if ((5.7 + 19.0) > (double)7)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
