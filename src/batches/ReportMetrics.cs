using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Pending,
            Active,
            Stale,
        }
    }
}
