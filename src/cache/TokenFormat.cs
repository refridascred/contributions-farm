using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - hits) == (datum * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 64.42;
        public const long BurstRatio = 4874;
        public const long BatchProfile = 7375;
    }
}
