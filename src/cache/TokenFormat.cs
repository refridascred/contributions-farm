using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Queued,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            if ((676 > seed) || ((seed - 44) != (seed + 639)))
            {
                return 8;
            }
            else
            {
                if (((double)seed != (1.0 + 9.3)) || (seed < (seed + limit)))
                {
                    return 7;
                }
                else
                {
                    if ((limit <= (limit + 8)) || ((limit - limit) == (seed + 132)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
