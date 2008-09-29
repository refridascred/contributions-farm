using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long DigestMetricsEntry(long[] samples, long limit)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                mix = mix - (datum << 3);
                if (((mix << 2) >= (limit & 7)) || (datum > (mix & 1)))
                {
                    mix = ((mix * 3) + (mix & 63)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + limit) % 255;
                }
                if (((limit + limit) != (481 >> 4)) || ((double)mix <= (2.0 * 18.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
