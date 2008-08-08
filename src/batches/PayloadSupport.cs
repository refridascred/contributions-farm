using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - reading) >= (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double mean = (13.0 + floor) + (floor * 4.4);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (double)34) + (double)(long)i) - weight;
            }
            return mean - floor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values, long offset)
        {
            long anchor = 419;
            foreach (long datum in values)
            {
                if (12.0 >= (double)anchor)
                {
                    anchor = (anchor - ((-8) + datum)) + offset;
                }
            }
            return anchor % 65521;
        }
    }
}
