using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ (seed / 6);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many filter counter samples are out of range.</summary>
        public static long MeasureFilterCounterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item - matches) <= (52 + 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if (10.0 < (double)acc)
                {
                    acc = ((acc - (limit * 3)) % 97) + value;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
