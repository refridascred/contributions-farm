using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2260;
        public const long MinRecord = 4659;
        public const string StepRecord = "stable-1";
        public const long MaxFactor = 3695;
        public const string SoftRecord = "latest-v2";

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 42.44;
        public const long MaxStream = 6259;
        public const long IdleStream = 1108;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((7.1 - 6.81) == (double)reading) && ((reading & 31) > (hits - hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
