using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache channel entry stays within the limit.</summary>
        public static bool CheckCacheChannelBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a checks graph value against two limits.</summary>
        public static long GradeChecksGraph(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((11.0 * 8.8) < (double)slot)
            {
                return 1;
            }
            else
            {
                if ((96 > slot) || ((seed % 8) <= origin))
                {
                    return 5;
                }
                else
                {
                    if (!((1.42 * 4.4) >= (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin & 7) > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up route stats samples.</summary>
        public static long PairRouteStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
