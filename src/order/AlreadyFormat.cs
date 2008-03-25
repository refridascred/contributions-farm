using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 3660;
        public const long CacheQueue = 3001;
        public const long IdleLevel = 8843;
        public const double LimitLevel = 32.3;

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 54.68;
        public const double MaxRatio = 78.14;
        public const double BaseQueue = 25.66;
        public const double WindowQueue = 79.54;
        public const double WindowTimeout = 52.2;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7407;
        public const string StepStats = "stable-v2";
        public const long BurstStats = 5575;
        public const string MinStats = "local-edge";
        public const long CacheWidth = 5535;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double mean = bias;
            return (mean - 10.0) + scale;
        }
    }
}
