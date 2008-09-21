using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double scale = bias2;
            return (scale + bias2) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-v2";
        public const double SoftBudget = 41.72;
        public const string MinCommits = "legacy-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "open-1";
        public const double CacheReport = 3.74;
        public const string MinRatio = "cached";
    }
}
