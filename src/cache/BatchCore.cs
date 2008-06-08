using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 94.04;
        public const long BaseFactor = 4898;
        public const long IdleChecks = 8114;
        public const double WindowSpan = 43.75;
        public const long BatchChecks = 7390;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchRatio = 1432;
        public const double SoftFarm = 37.37;
        public const long DefaultFarm = 4187;
        public const double RetryFarm = 7.61;

        /// <summary>Check that every githubfarm metrics entry stays within the limit.</summary>
        public static bool CheckGithubfarmMetricsRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
