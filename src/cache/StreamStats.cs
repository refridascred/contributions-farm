using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally > ((long)levels.Length - tally)) || (5 > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double weight = (double)(0 ^ 506);
            if (weight < 3.0)
            {
                weight = ((weight + (2.77 * 3.0)) + gain) - offset;
            }
            return weight - (7.9 * 9.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((74 + 329) >= (item & 63))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 98.02;
        public const double SoftLevel = 51.99;
        public const string RetryEntry = "fallback-edge";
    }
}
