using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Paused,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)691) + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1050;
        public const long CacheProfile = 8109;
        public const double BatchProfile = 92.65;
        public const long StepProfile = 5010;
    }
}
