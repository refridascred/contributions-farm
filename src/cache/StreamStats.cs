using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a metric profile counter forward.</summary>
        public static long SeriesMetricProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((8.1 / 5.0) > (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor & 255);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target / 7) <= (64 + 7))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleCount = 78.3;
        public const long BaseFactor = 4807;
        public const string DefaultDepth = "legacy-edge";
        public const string BaseWidth = "latest-edge";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Done,
            Stale,
            Paused,
            New,
        }
    }
}
