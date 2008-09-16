using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryBudget = "strict";
        public const double MaxFactor = 2.73;
        public const string WindowScore = "legacy-1";

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
