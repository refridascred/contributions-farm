using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9426;
        public const double SoftOrder = 22.06;
        public const double BatchFactor = 25.17;
    }
}
