using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long MeasureChecksCacheHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)3 <= (double)step)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi command entries that pass the check.</summary>
        public static long MeasureContributiCommandMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((15 & 7) > tally) || (tally < (-500))) || ((tally < (tally >> 3)) || ((entry / 4) > 9)))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
