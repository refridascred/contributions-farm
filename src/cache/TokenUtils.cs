using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank support metric input into a small class.</summary>
        public static long RankSupportMetric(long seed, long limit)
        {
            long next = seed ^ limit;
            if (((990 + next) <= 80) && ((double)limit >= (double)seed))
            {
                return 4;
            }
            else
            {
                if (!((next & 31) == (31 % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 31) <= (seed - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (seed >> 2))
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
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Paused,
            Draft,
        }
    }
}
