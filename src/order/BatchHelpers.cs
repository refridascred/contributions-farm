using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long RollToolsChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((890 - origin) == (anchor ^ 85))
                {
                    anchor = (anchor - ((long)i * 3)) % 1000;
                    anchor = (anchor + ((long)i - anchor)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
