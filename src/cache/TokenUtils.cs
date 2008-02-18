using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((5 - count) < count)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinWidth = 84.88;
        public const long CacheSupport = 341;
        public const long RetryLevel = 5536;
        public const string LimitSupport = "stable-edge";
        public const double WindowSupport = 94.23;
    }
}
