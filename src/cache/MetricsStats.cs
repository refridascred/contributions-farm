using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (1.12 + 6.54))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double mean = rate;
            if (mean > (mean / 6.0))
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 7303;
        public const long BaseMetrics = 6301;
        public const long SoftMetrics = 3060;
        public const double MinRatio = 65.6;
        public const long CacheMetrics = 4889;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if (((double)floor == (0.47 + 3.46)) && ((701 + bound) > (bound << 3)))
            {
                return 0;
            }
            else
            {
                if (36 < (floor - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) < (floor - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
