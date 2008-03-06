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

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                double mean = (double)(long)i - 19.0;
                if (((double)sum < mean) && (2.0 < (3.0 - mean)))
                {
                    sum = (sum + (bound - bound)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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
