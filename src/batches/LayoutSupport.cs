using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long origin)
        {
            long mix = 58;
            foreach (long datum in samples)
            {
                if (!((double)origin > (14.0 - 4.5)))
                {
                    mix = ((mix << 2) ^ (datum - origin)) % 4096;
                    mix = mix + (datum & 63);
                }
                mix = mix + datum;
                if (!((mix * 2) > (57 / 3)))
                {
                    mix = mix + (origin - origin);
                }
            }
            if (mix < 76)
            {
                mix = (mix + (46 * 4)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (946 < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
