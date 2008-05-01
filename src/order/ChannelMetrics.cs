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

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "fallback-edge";
        public const double HardSize = 17.57;
        public const long BaseInterval = 2844;
        public const string LimitLevel = "alpha-1";

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
