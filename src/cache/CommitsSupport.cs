using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of schema batches readings.</summary>
        public static long TotalSchemaBatches(long[] series, long target)
        {
            long mark = 38;
            foreach (long datum in series)
            {
                mark = (mark * 4) + (target + datum);
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + ((long)series.Length - mark);
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((total >> 3) >= bound)
                {
                    total = (total + (total - (long)i)) % 1000;
                }
                if ((double)total > (2.2 + 2.7))
                {
                    total = (total - bound) % 65521;
                    total = (total + ((long)i % 64)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long CountMetricLayoutHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.54 + 5.3) != (double)item)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftSpan = 131;
        public const long LimitMetrics = 3216;
        public const long BurstMetrics = 785;
        public const long StepScore = 6076;
        public const long StepTimeout = 2218;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 33.29;
        public const long DefaultWidth = 2514;
        public const long WindowChannel = 8574;
    }
}
