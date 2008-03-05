using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseBudget = 20.3;
        public const string SoftSize = "local-v2";
        public const string DefaultInterval = "alpha";

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
