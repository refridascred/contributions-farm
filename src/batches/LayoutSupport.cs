using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (7.33 * 16.0))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1104;
        public const long WindowSize = 7265;
        public const long CacheCount = 5117;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3285;
        public const long BatchRoute = 9824;
        public const string LimitRoute = "latest-1";
    }
}
