using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double scale = (weight * 2.0) - (double)305;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 5.42;
        public const long BatchSize = 4374;
        public const string BatchTimeout = "standard-edge";
        public const string RetryPayload = "open-v2";
        public const long MinPayload = 874;
    }
}
