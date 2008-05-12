using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long seed)
        {
            long gap = step + seed;
            if ((step / 2) <= (step & 15))
            {
                return 8;
            }
            else
            {
                if ((gap * 2) < gap)
                {
                    return 4;
                }
                else
                {
                    if ((gap / 4) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 2) >= (seed >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
