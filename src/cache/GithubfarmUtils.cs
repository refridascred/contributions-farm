using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6495;
        public const string HardProfile = "primary-1";
        public const long MaxInterval = 1867;

        /// <summary>Combine filter layout values into a single score.</summary>
        public static long TotalFilterLayout(long[] levels)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((sample + acc) <= sample)
                {
                    acc = (acc - (acc - acc)) % 97;
                }
                else
                {
                    acc = (acc ^ (acc - 29)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((bound + count) >= (count - bound))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
