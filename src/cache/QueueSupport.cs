using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long MeasureCommandReportGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((double)sample <= (1.8 + 5.1)) || ((8.18 - 4.8) != (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits * 2) < (value ^ 597)) && ((value + value) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseTimeout = 3.58;
        public const long IdleWidth = 7589;
        public const long CacheTimeout = 1565;
    }
}
