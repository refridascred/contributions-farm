using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open-edge";
        public const string SoftWindow = "legacy-v2";
        public const string HardBudget = "local-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 1428;
        public const string BatchRatio = "alpha-edge";
        public const long BatchDepth = 1244;
        public const long StepSize = 5380;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
