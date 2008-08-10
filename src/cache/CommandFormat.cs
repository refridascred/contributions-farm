using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy-1";
        public const long HardMetric = 4370;
        public const long DefaultMetric = 8977;
        public const string BatchMetric = "cached-1";

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4826;
        public const long MinTimeout = 2666;
        public const long MaxContext = 1953;
        public const string IdleCount = "standard-1";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultRatio = 86.16;
        public const string BurstAlready = "strict-1";
        public const long LimitBudget = 567;
        public const string BurstFactor = "primary-1";
    }
}
