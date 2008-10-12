using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Failed,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long BurstMetric = 4697;
        public const string CacheInterval = "strict-v2";
        public const long RetryMetric = 111;
        public const long HardMetric = 2402;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9170;
        public const string BaseDepth = "stable-edge";
        public const double WindowCommits = 30.32;
        public const double RetryWidth = 7.89;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
