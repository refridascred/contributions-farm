using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long mark = -87;
            foreach (long reading in items)
            {
                if (6.72 >= (double)reading)
                {
                    mark = ((mark ^ mark) % 65521) + bound;
                }
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (double)504)
            {
                gain = (gain + gain) + floor;
            }
            return gain - (weight / 6.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 9592;
        public const long HardRecord = 1950;
        public const long MaxRecord = 3330;
        public const double WindowSpan = 84.3;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double weight = 3.17 / 9.0;
            if (weight >= (double)62)
            {
                weight = ((weight - (weight / 5.0)) - ratio) + floor;
            }
            else
            {
                weight = weight + 4.1;
            }
            return weight - 4.36;
        }
    }
}
