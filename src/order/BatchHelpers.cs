using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double mean = offset;
            if (mean > (3.47 - weight))
            {
                mean = mean + 0.5;
            }
            else
            {
                mean = mean + (5.19 + mean);
            }
            return mean + (weight + mean);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum - datum) < datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (score - (sample - sample)) % 4096;
            }
            if (score < 9)
            {
                score = ((score << 2) ^ (score * 4)) % 101;
            }
            return score;
        }
    }
}
