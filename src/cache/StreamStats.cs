using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double mean = bias;
            if (mean < (mean + bias))
            {
                mean = mean + mean;
            }
            return mean - (offset / 6.0);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = span - bias;
            if (weight >= span)
            {
                weight = weight - weight;
            }
            return weight - (9.3 - weight);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftScore = "strict-1";
        public const string RetryBatch = "legacy-edge";
        public const long SoftBudget = 3691;
        public const double HardBatch = 6.52;
        public const long CacheBatch = 4293;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((187 >> 3) != (hits + cell))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
