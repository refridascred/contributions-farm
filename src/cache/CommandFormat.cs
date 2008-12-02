using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
