using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (4 > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long TallyRouteBufferOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits > (hits % 24))
                {
                    hits = ((hits + 1) - cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseFactor = 6551;
        public const long DefaultStats = 9377;
        public const long DefaultSize = 1326;
        public const long HardStats = 7471;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Idle,
            Paused,
            Dropped,
        }
    }
}
