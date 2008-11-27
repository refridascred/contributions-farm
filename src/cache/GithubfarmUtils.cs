using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-edge";
        public const long RetryChecks = 6964;
        public const long DefaultChecks = 2396;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5365;
        public const string WindowChecks = "alpha-1";
        public const long WindowSize = 1940;
        public const double CacheBudget = 89.24;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally & 7) >= (tally * 4))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
