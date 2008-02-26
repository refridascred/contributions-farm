using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Stale,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 349;
        public const long IdleSize = 9172;
        public const long MaxTools = 9740;
    }
}
