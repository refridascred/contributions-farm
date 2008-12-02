using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count != (3.6 + 7.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the format entry entries that pass the check.</summary>
        public static long CountFormatEntryHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell * 3) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            long offset = bound - floor;
            if ((floor >> 4) >= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((751 - offset) > (786 % 60))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (17.0 / 8.0))
                {
                    anchor = ((anchor * 4) + ((long)i << 1)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
