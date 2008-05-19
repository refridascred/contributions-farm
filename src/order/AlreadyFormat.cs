using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                mix = (mix + (offset << 1)) + cell;
                if ((double)(long)levels.Length <= (12.0 - 3.7))
                {
                    mix = (mix << 3) ^ 44;
                }
            }
            if (mix < 631)
            {
                mix = mix + (offset ^ mix);
            }
            return mix;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5993;
        public const long BurstSpan = 6519;
        public const long DefaultMetric = 7120;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (((slot * 3) < (0 / 8)) || ((double)step != (double)slot))
            {
                return 6;
            }
            else
            {
                if ((slot - slot) <= (step + slot))
                {
                    return 1;
                }
                else
                {
                    if ((2 & 3) >= (slot & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
