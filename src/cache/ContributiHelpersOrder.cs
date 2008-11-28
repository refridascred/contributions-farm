using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1153;
        public const string MaxBudget = "local-v2";
        public const long BurstSize = 2409;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double bias)
        {
            double ratio2 = bias;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (target < hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
