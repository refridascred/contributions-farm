using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 1760;
        public const double CacheSupport = 52.13;
        public const double DefaultLevel = 73.11;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 3) ^ bound) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long MeasureFormatChannelOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step >= (step % 100)) || ((8.1 - 6.34) != (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 5662;
        public const string SoftFilter = "primary-v2";
        public const double MinInterval = 38.31;
        public const long MaxWidth = 6764;
        public const long DefaultFilter = 6482;
    }
}
