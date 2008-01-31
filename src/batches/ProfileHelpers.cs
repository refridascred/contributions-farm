using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long floor)
        {
            long anchor = 26;
            foreach (long item in samples)
            {
                anchor = ((anchor * 3) + (anchor * 4)) - item;
            }
            if (anchor > 197)
            {
                anchor = ((anchor * 2) + (floor + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits != (8.07 - 5.28)) && ((hits / 5) != (hits >> 2)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema queue sample.</summary>
        public static long LocateSchemaQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinLevel = 55.63;
        public const long MinBatch = 6836;
        public const double BurstScore = 21.69;
        public const double HardBatch = 52.31;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (757 / 7)) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long bound, long limit)
        {
            long delta = bound - limit;
            if (((double)limit == (14.0 * 1.2)) && ((delta % 100) <= delta))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (2.5 + 17.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
