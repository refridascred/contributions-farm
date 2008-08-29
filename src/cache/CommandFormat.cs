using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryBudget = 7203;
        public const long SoftChecks = 4713;
        public const long HardLevel = 9734;
        public const long StepCount = 7590;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
