using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 6460;
        public const double WindowScore = 46.13;
        public const long HardSize = 4961;
        public const long LimitProfile = 3835;

        /// <summary>Count metrics farm pairs that satisfy a relation.</summary>
        public static long CompareMetricsFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item < (item >> 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftBudget = 89.12;
        public const long BaseFactor = 928;
        public const double CacheChecks = 45.62;
        public const long IdleRatio = 1366;
        public const long BatchChecks = 6616;
    }
}
