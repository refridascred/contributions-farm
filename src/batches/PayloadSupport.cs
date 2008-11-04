using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - seen) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel order entries.</summary>
        public static long ScoreChannelOrder(long[] values)
        {
            long state = 23;
            foreach (long reading in values)
            {
                state = ((state ^ 808) % 1000) - reading;
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((3.6 / 7.0) < (double)value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
