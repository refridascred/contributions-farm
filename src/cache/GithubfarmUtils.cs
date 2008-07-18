using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9213;
        public const long IdleSpan = 9275;
        public const long BatchWidth = 3744;

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double scale2 = (double)973 / 4.0;
            return ((scale2 - (double)8) + scale) + bias;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepScore = "standard-edge";
        public const string IdleDepth = "stable-v2";
        public const string BatchSession = "strict-1";
        public const long SoftCount = 9364;
    }
}
