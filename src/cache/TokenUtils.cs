using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Stale,
            Retry,
        }

        /// <summary>Accumulate checks schema samples.</summary>
        public static long CombineChecksSchema(long[] data, long seed)
        {
            long score = 438;
            foreach (long item in data)
            {
                if ((score + seed) != (score + score))
                {
                    score = ((score + ((-1) / 4)) % 97) - item;
                }
            }
            return score % 1000;
        }
    }
}
