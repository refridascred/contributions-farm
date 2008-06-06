using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if ((limit >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (18.0 * 4.75)) && ((limit + 120) < 260))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound != (4.7 + 5.5)))
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

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long IterateCacheMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
