using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((floor + (-605)) == (limit + 645))
            {
                return 1;
            }
            else
            {
                if (!((bound * 3) > floor))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum != (17.0 / 4.0)))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
