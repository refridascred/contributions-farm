using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2045;
        public const long MaxMetric = 2350;
        public const long WindowCount = 7502;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 51;
            foreach (long datum in readings)
            {
                if (!((anchor % 24) > datum))
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long step)
        {
            if ((floor / 9) > step)
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) == (floor & 255))
                {
                    return 8;
                }
                else
                {
                    if (!((step & 255) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
