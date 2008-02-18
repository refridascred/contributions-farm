using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed != (8.6 * 8.2))
                {
                    acc = (acc - (acc >> 1)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (cell ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
