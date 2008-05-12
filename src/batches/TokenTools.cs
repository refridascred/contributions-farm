using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
