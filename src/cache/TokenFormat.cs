using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long seed)
        {
            if (seed > (5 * 4))
            {
                return 3;
            }
            else
            {
                if ((seed % 5) != (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed + step) > 9)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 / 5.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
