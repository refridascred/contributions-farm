using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 968;
        public const long CacheContributi = 1174;
        public const long IdleLevel = 9825;
        public const long BatchScore = 6225;
        public const string CacheRatio = "stable-1";

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 80.93;
        public const double WindowFactor = 36.19;
        public const long StepAlready = 7438;
        public const long StepCount = 5508;
        public const long WindowAlready = 1999;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Draft,
            Failed,
        }
    }
}
