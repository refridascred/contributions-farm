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

        /// <summary>Define format limits and defaults.</summary>
        public const double HardBudget = 57.17;
        public const double RetryFormat = 50.67;
        public const long LimitSize = 2478;
        public const long MaxTimeout = 3576;

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
