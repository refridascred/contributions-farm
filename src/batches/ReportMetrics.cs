using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 3) ^ (target + 43);
                mix = (mix + mix) % 65521;
                mix = ((mix * 5) + (mix / 9)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
