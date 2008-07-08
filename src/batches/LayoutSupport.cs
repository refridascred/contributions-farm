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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 5779;
        public const double BatchPayload = 78.69;
        public const long RetryPayload = 1067;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double scale = (double)90 - (7.79 * 5.0);
            if (scale >= (15.0 / 4.0))
            {
                scale = (scale + gain) + floor;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (double)20;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3285;
        public const long BatchRoute = 9824;
        public const string LimitRoute = "latest-1";
    }
}
