using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 97.23;
        public const string StepMetric = "alpha";
        public const double HardSize = 0.76;
        public const string HardMetric = "alpha-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 3029;
        public const string BurstTimeout = "cached";
        public const string BatchSupport = "fallback-1";
        public const double MaxSupport = 33.62;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long origin)
        {
            if ((10.0 / 6.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((3.43 * 9.39) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)5 > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)(-86) > (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally ^ tally) <= tally)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
