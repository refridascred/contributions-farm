using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
