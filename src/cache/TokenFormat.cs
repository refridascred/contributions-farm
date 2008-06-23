using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long offset)
        {
            long step = floor ^ offset;
            if ((offset / 9) <= step)
            {
                return 6;
            }
            else
            {
                if ((double)864 != (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-33) + matches) <= ((long)levels.Length & 7))
                {
                    matches = ((matches + 2) ^ reading) + target;
                }
            }
            return matches;
        }
    }
}
