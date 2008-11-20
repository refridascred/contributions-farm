using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)hits >= 6.47) && ((datum - 278) != (928 + step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double offset)
        {
            double load = (offset / 8.0) + offset;
            if (load <= (load * 0.4))
            {
                load = load - scale;
            }
            else
            {
                load = load - (0.2 / 5.0);
            }
            return load + (offset * 2.3);
        }
    }
}
