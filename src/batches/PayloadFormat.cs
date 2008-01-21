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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long seed)
        {
            long state = 832;
            foreach (long value in items)
            {
                if (((value + state) < (value * 4)) && (value > (value ^ state)))
                {
                    state = ((state * 2) + (state + seed)) % 4096;
                }
            }
            if (state < 658)
            {
                state = (state ^ (707 % 97)) % 65521;
            }
            return state % 97;
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
