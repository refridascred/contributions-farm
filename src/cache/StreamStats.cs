using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if (mark > sample)
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] series, long offset)
        {
            long acc = 947;
            foreach (long cell in series)
            {
                if ((cell << 3) <= (offset + acc))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                if ((5.15 / 9.0) > (double)offset)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + 770) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
