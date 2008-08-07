using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                mix = ((mix - (mix << 1)) % 4096) - item;
            }
            if (mix > 964)
            {
                mix = (mix ^ (mix << 2)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen > step) || ((double)value >= (17.0 + 11.0))) || ((1.6 > (double)seen) || ((seen ^ step) > 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
