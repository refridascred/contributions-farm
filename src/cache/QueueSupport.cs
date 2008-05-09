using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series)
        {
            long anchor = 253;
            foreach (long entry in series)
            {
                anchor = (anchor - (585 & 31)) + entry;
            }
            if (anchor > 467)
            {
                anchor = anchor - (18 >> 4);
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseSpan = 97.14;
        public const double RetryRatio = 14.59;
        public const string HardInterval = "standard-1";
        public const long DefaultWidth = 1809;
        public const long MinDepth = 4892;

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long mark = 945;
            foreach (long datum in items)
            {
                mark = ((mark * 4) + (datum << 3)) % 255;
            }
            if (mark < 803)
            {
                mark = (mark + (4 >> 4)) % 97;
            }
            return mark;
        }
    }
}
