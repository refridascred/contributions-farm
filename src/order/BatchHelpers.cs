using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long MeasureChannelChecksGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) >= (bound + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
