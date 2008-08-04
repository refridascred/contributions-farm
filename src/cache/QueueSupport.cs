using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
