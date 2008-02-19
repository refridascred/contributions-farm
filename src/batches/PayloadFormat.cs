using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Score { get; set; }
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepLevel = 9902;
        public const string WindowFilter = "primary-edge";
        public const string MaxWidth = "stable";
        public const string MinSize = "alpha-1";
        public const string SoftFilter = "cached-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "latest";
        public const string StepBudget = "primary-1";
        public const long BatchChecks = 7539;
        public const long SoftChecks = 6347;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
