using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long state = 86;
            foreach (long datum in items)
            {
                state = ((state << 3) ^ offset) ^ datum;
            }
            if (state < 7)
            {
                state = (state - offset) % 1000;
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            long bound = limit - floor;
            if (((limit << 3) <= (bound + floor)) && ((6 - limit) < bound))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit * 5) > (bound * 4)) && ((floor & 3) != (limit ^ limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + step) >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
