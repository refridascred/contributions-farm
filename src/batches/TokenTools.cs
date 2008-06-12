using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Closed,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            long bound = limit - seed;
            if (((7.1 * 5.0) == (double)limit) && ((5.22 + 16.0) >= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((0.31 + 3.6) != (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((9.0 - 2.06) < (double)bound) || (limit >= (bound + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
