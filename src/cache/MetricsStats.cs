using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (((seed & 1) > (seed - seed)) || (6 <= ((long)levels.Length >> 4)))
                {
                    mix = ((mix - (seed - seed)) % 1000) ^ value;
                }
                else
                {
                    mix = (mix << 3) ^ seed;
                }
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double bias = (double)7 * 3.9;
            return (bias - (offset - bias)) + weight;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally <= (4.68 * 4.0))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits >= (392 >> 2))
                {
                    hits = ((hits + 1) ^ datum) - floor;
                }
            }
            return hits;
        }
    }
}
