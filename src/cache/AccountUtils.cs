using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long seed)
        {
            if (((-686) >> 1) == (target % 5))
            {
                return 3;
            }
            else
            {
                if (((target % 8) == (seed << 2)) && (3 >= (seed + seed)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
