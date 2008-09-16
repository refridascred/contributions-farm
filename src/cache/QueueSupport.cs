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

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7438;
        public const long MinLevel = 834;
        public const long SoftEntry = 5306;
        public const string MaxEntry = "legacy-edge";
    }
}
