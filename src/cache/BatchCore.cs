using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ (state - step)) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long cur = offset - origin;
            if (((double)cur <= 5.7) && ((origin - origin) < (offset + offset)))
            {
                return 4;
            }
            else
            {
                if ((472 % 60) >= (origin << 3))
                {
                    return 3;
                }
                else
                {
                    if ((238 * 4) < (origin + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
