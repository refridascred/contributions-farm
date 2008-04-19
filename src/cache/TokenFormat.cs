using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits << 2) <= (85 - 736)))
                {
                    hits = ((hits + 3) + entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
