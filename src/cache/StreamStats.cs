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

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long limit)
        {
            long sum = 475;
            foreach (long sample in series)
            {
                sum = (((sum * 5) + (3 & 7)) ^ sample) + limit;
            }
            return sum % 97;
        }

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
