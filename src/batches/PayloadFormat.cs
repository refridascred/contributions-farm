using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) == (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a route graph value against two limits.</summary>
        public static long ClassifyRouteGraph(long offset, long bound)
        {
            long lane = offset - bound;
            if (!((bound - lane) <= bound))
            {
                return 2;
            }
            else
            {
                if (((double)offset >= 9.8) || ((offset % 24) <= (lane + offset)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] values, long seed)
        {
            long sum = 73;
            foreach (long value in values)
            {
                if (!((45 << 1) < value))
                {
                    sum = ((sum * 3) + 8) % 65521;
                }
                sum = (sum * 4) + (580 & 63);
                sum = (sum + (seed * 5)) % 4096;
            }
            return sum;
        }
    }
}
