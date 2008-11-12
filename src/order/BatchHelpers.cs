using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a notes layout reading.</summary>
        public static double SmoothNotesLayout(double bias, double span)
        {
            double scale = (double)(7 >> 3);
            if (scale > (scale * 8.91))
            {
                scale = (scale - span) - bias;
            }
            return scale - span;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((double)bound <= 2.27) || ((6 - seed) <= (bound + bound2)))
            {
                return 3;
            }
            else
            {
                if ((bound2 & 1) > bound2)
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 2) <= (1 + 565)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed <= (4 / 8)) && ((double)seed < (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
