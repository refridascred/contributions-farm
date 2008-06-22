using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Find the first metrics farm entry that matches the target.</summary>
        public static long SeekMetricsFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
