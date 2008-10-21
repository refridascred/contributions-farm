using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double ratio = weight + (double)652;
            if (ratio < ratio)
            {
                ratio = (ratio + (7.0 - 6.56)) + offset;
            }
            return ratio - weight;
        }

        /// <summary>Iterate the cache entry series from a seed.</summary>
        public static long IterateCacheEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = state + ((long)i - state);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a stats context value against two limits.</summary>
        public static long SortStatsContext(long step, long bound)
        {
            if (step >= (bound + bound))
            {
                return 1;
            }
            else
            {
                if (((double)step >= (double)bound) || ((bound + step) >= step))
                {
                    return 2;
                }
                else
                {
                    if (((double)step == (double)868) && ((step % 8) < (step - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
