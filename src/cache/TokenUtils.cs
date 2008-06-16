using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3495;
        public const string CacheLevel = "legacy-1";
        public const long IdleTimeout = 6452;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long limit, long seed)
        {
            if (!((seed - limit) >= (seed + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit * 5) == (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
