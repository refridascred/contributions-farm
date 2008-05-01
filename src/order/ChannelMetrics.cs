using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 5) <= (hits + (-85)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long seed)
        {
            long mark = 5;
            foreach (long entry in readings)
            {
                if ((mark + mark) < (entry / 5))
                {
                    mark = mark - (entry + seed);
                }
                else
                {
                    mark = mark - (mark & 3);
                }
            }
            return mark;
        }
    }
}
