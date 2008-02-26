using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

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
