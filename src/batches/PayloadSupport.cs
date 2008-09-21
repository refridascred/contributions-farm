using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 57.06;
        public const double RetryWidth = 23.57;
        public const long MaxFactor = 8275;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultInterval = 79.91;
        public const double BurstDepth = 38.68;
        public const double SoftProfile = 87.66;
        public const double CacheTimeout = 16.52;
    }
}
