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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data)
        {
            long anchor = 862;
            foreach (long value in data)
            {
                anchor = (((anchor << 3) ^ (96 + anchor)) % 101) ^ value;
                anchor = ((anchor * 3) + 362) % 97;
            }
            return anchor % 65521;
        }
    }
}
