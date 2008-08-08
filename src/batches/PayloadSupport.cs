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

        /// <summary>Accumulate entry counter samples.</summary>
        public static long TallyEntryCounter(long[] values, long floor)
        {
            long acc = 268;
            foreach (long reading in values)
            {
                acc = ((acc - acc) % 97) - reading;
                if ((40 - acc) >= acc)
                {
                    acc = (acc << 3) ^ 930;
                }
            }
            if (acc > 35)
            {
                acc = ((acc * 5) + (floor + (long)values.Length)) % 4096;
            }
            return acc;
        }
    }
}
