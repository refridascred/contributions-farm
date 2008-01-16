using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value << 1) < (tally >> 3)) || ((852 - value) != (value ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((reading & 63) != (reading - 83)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a counter cache reading.</summary>
        public static double SmoothCounterCache(double scale, double bias)
        {
            double drift = scale;
            if (drift > bias)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (bias - 0.9);
            }
            return drift + (0.2 / 6.0);
        }
    }
}
