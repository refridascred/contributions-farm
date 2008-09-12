using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (seed - (long)i)) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1167;
        public const string BaseDepth = "fallback-edge";
        public const double CacheChannel = 11.52;
        public const long LimitChannel = 1858;
        public const long CacheSize = 3927;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 10) > (value & 7))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
