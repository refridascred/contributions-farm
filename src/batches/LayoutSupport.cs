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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 580;
            foreach (long entry in series)
            {
                if ((acc ^ entry) == (31 + acc))
                {
                    break;
                }
                else
                {
                    acc = acc + (586 & 255);
                }
                acc = acc - (acc + acc);
            }
            if (acc > 286)
            {
                acc = acc ^ (84 & 15);
            }
            return acc;
        }

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
