using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading + reading) >= hits) || ((hits >> 1) > (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) >= reading)
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((double)seed < (7.0 + 18.0))
            {
                return 2;
            }
            else
            {
                if ((0 * 4) <= (target + target))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
