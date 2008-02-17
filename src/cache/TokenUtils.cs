using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long limit)
        {
            long lane = target + limit;
            if ((double)limit == (5.15 * 6.0))
            {
                return 8;
            }
            else
            {
                if ((double)lane < (6.63 * 9.9))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
