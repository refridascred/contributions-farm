using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + seen) >= (origin + origin))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine report cache values into a single score.</summary>
        public static long TotalReportCache(long[] readings)
        {
            long anchor = 757;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 3) + ((-61) & 63)) + entry;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
