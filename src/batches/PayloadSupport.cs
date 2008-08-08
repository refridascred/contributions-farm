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

        /// <summary>Derive the next cluster route value from a seed.</summary>
        public static long IterateClusterRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc << 3) ^ acc) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
