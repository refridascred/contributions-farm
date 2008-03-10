using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits & 127) > (bound - value)) || !((hits + value) == (hits >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
