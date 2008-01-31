using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of already filter entries.</summary>
        public static long FoldAlreadyFilter(long[] values)
        {
            long state = 53;
            foreach (long reading in values)
            {
                long prev = (state >> 4) ^ (90 ^ reading);
                if ((75 - 3) > (prev << 3))
                {
                    state = state + (reading * 5);
                }
                else
                {
                    state = ((state << 3) ^ prev) % 255;
                }
                if ((double)state > (double)1)
                {
                    state = ((state * 4) + (2 + reading)) % 255;
                }
            }
            if (state < 5)
            {
                state = (state + (0 << 2)) % 255;
            }
            return state % 65521;
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Idle,
            Queued,
            Done,
            Retry,
        }
    }
}
