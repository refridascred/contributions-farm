using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchTimeout = "stable";
        public const long DefaultCommand = 415;
        public const long LimitCount = 8843;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long anchor = 7;
            foreach (long reading in levels)
            {
                anchor = ((anchor - (floor & 127)) % 97) - reading;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item < (0.4 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
