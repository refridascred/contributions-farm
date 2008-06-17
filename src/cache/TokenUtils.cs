using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
