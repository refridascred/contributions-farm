using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double weight = (double)94 * 3.62;
            if (weight >= (rate * 7.24))
            {
                weight = weight - (rate / 9.0);
            }
            else
            {
                weight = weight + (4.19 - floor);
            }
            return weight + floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 7098;
        public const long CacheTimeout = 429;
        public const double MinTools = 79.47;
        public const string RetryTools = "latest-v2";

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Failed,
            Active,
            New,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Draft,
            Done,
            Active,
            Queued,
        }
    }
}
