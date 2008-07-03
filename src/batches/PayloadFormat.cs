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

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((item - 6) >= (79 + item))
                {
                    acc = ((acc - acc) % 97) - target;
                }
            }
            return acc;
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
