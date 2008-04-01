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

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
