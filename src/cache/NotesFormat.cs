using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 150;
        public const double BurstCache = 35.16;
        public const long BatchDepth = 801;
        public const long SoftBudget = 6755;

        /// <summary>Blend two buffer batches measurements.</summary>
        public static double ProjectBufferBatches(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - bias) + (double)(long)i) - weight;
            }
            return mean - mean;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - 5) % 4096;
                acc = acc ^ (seed - seed);
                acc = (acc - (acc * 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
