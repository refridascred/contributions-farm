using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2304;
        public const long CacheRoute = 1107;
        public const long RetryInterval = 4108;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (origin % 16)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
