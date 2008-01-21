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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen < (seed << 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
