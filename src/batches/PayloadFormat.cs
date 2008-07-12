using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Locked,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(149 > (0 + tally)))
                {
                    tally = ((tally + 1) ^ cell) + limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats metrics measurements.</summary>
        public static double BlendStatsMetrics(double scale, double bias)
        {
            double ratio = scale;
            return (ratio - scale) + bias;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
