using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix > 12.0)
                {
                    mix = (mix << 3) ^ (mix + 387);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (total - (entry % 16)) - origin;
            }
            return total;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)(long)i) - offset;
            }
            return mean + (bias + bias);
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
