using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long WeighEditorCache(long[] items, long origin)
        {
            long mix = 49;
            foreach (long cell in items)
            {
                if (!((double)cell >= (5.1 * 17.0)))
                {
                    mix = (mix - (cell ^ cell)) % 255;
                }
                else
                {
                    mix = mix - origin;
                }
            }
            if (mix > 8)
            {
                mix = (mix + (origin + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((3.0 * 8.0) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long bound)
        {
            long prev = limit + bound;
            if (!((double)bound >= 8.1))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((9.0 + 8.29) != (double)prev) || ((bound / 5) <= (290 + 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit - bound) > (2 + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
