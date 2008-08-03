using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (7.3 + 2.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultTimeout = "staging-edge";
        public const long BatchBatches = 4851;
        public const long DefaultBudget = 7488;
        public const string MinRatio = "strict-1";
        public const double MinCount = 62.2;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-edge";
        public const double SoftFilter = 18.35;
        public const string StepFactor = "latest";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            New,
            Locked,
            Synced,
        }
    }
}
