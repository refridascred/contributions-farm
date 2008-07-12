using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardScore = "cached-v2";
        public const string DefaultInterval = "fallback-edge";
        public const string BurstMetric = "alpha";
        public const long MaxWidth = 1130;
        public const long CacheMetric = 6349;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally & 7) < (423 ^ tally))
                {
                    tally = ((tally + 1) + item) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer farm samples are out of range.</summary>
        public static long MeasureBufferFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((double)tally <= (double)reading) || (reading >= (reading >> 3))) || (((tally - reading) < 725) && ((reading - (-329)) > (reading << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
