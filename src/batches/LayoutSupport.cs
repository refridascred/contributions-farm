using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((90 + hits) <= (hits >> 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8.53 + 9.7) >= (double)value)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long SeriesCounterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - (long)i) >= (anchor & 7))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value * 5) < (value & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
