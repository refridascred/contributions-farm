using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7758;
        public const string BatchInterval = "strict";
        public const long MaxWidth = 3370;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor / 7) < (floor * 2))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
