using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
