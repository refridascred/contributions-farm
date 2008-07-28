using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long bound)
        {
            if ((double)offset <= (5.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 4.1)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(sample <= (sample + sample)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ScaleMetricCommits(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight * 5.21)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}
