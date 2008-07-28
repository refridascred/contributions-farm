using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm window samples are out of range.</summary>
        public static long CountGithubfarmWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + hits) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
