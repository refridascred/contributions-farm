using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long origin)
        {
            long delta = limit - origin;
            if ((10.0 / 9.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (delta >= (delta << 3))
                {
                    return 1;
                }
                else
                {
                    if (delta > (origin * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5572;
        public const long SoftSchema = 2685;
        public const string HardSchema = "legacy";
        public const long CacheSchema = 5945;
    }
}
