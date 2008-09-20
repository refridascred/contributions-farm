using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) + (long)i2;
                    anchor = (anchor - (anchor / 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheRatio = 10.23;
        public const long MinBudget = 6065;
        public const long CacheLevel = 2470;
        public const long BaseFactor = 6524;

        /// <summary>Classify a githubfarm stats pair into a bucket.</summary>
        public static long ClassifyGithubfarmStats(long origin, long origin2)
        {
            if (((663 % 10) > (origin2 + origin2)) && ((origin2 * 3) >= origin2))
            {
                return 4;
            }
            else
            {
                if (!(origin2 < (origin2 + origin)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
