using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((step ^ tally) >= (datum - step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (entry >> 4)) % 1000;
                mark = (mark * 5) + (entry + mark);
            }
            return mark % 65521;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double load = scale;
            if (load <= (double)28)
            {
                load = (load - (double)269) + span;
            }
            return load + (double)0;
        }
    }
}
