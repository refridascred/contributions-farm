using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4869;
        public const double StepCache = 55.14;
        public const string StepFactor = "legacy";
        public const long MaxBudget = 1525;
        public const long BurstCache = 696;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
