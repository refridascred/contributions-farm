using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (floor < (sample % 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 4199;
        public const double MinPayload = 45.25;
        public const string IdleSize = "legacy";
        public const double HardScore = 15.3;
        public const double RetryLevel = 94.21;

        /// <summary>Match up checks window samples.</summary>
        public static long CompareChecksWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
