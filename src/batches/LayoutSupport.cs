using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 863;
        public const long BatchSupport = 241;
        public const string HardInterval = "standard-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Retry,
            Dropped,
            Ready,
        }
    }
}
