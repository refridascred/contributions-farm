using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double scale = bias;
            return (scale + bias) + weight;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value > (value % 16))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
