using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2013;
        public const double BatchLevel = 35.26;
        public const long HardSize = 333;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
